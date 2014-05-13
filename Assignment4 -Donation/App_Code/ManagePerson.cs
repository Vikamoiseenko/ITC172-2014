using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for ManageCustomer
/// </summary>
public class ManagePerson
{


    SqlConnection connect;
    Person c;
    

    public ManagePerson()
    {
        connect = new SqlConnection
            (ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
        
    }


    public SqlCommand WritePerson()
    {
        string sqlPerson = "Insert into Person (PersonLastName, PersonFirstName, PersonUsername, PersonPlainPassword, Personpasskey, PersonUserPassword, PersonEntryDate) Values (@LastName, @FirstName, @Username, @PlainPassword, @Passcode, @HashedPassword, @DateTime)";
                
        PasscodeGenerator pg = new PasscodeGenerator();
        PasswordHash ph = new PasswordHash();
        int passcode = pg.GetPasscode();

        SqlCommand personCmd = new SqlCommand(sqlPerson, connect);
        personCmd.Parameters.AddWithValue("@LastName", c.LastName);
        personCmd.Parameters.AddWithValue("@FirstName", c.FirstName);
        personCmd.Parameters.AddWithValue("@UserName", c.Email);
        personCmd.Parameters.AddWithValue("@PlainPassword", c.PlainPassword);
        personCmd.Parameters.AddWithValue("@Passcode", passcode);
        personCmd.Parameters.AddWithValue("@HashedPassword", ph.HashIt(c.PlainPassword, passcode.ToString()));
        personCmd.Parameters.AddWithValue("@DateTime", DateTime.Now);

                
        return personCmd;
    }


    public SqlCommand WritePersonAddress()
    {
        string sqlPersonAddress = "Insert into Person.PersonAddress(Street, Apartment, State, City, Zip, PersonKey) " +
           "Values(@Street, @Apartment, @State, ident_Current('Person'))";
        SqlCommand PersonAddressCmd = new SqlCommand(sqlPersonAddress, connect);
        PersonAddressCmd.Parameters.AddWithValue("@Street", c.Address);
        PersonAddressCmd.Parameters.AddWithValue("@Apartment", c.Apartment);
        PersonAddressCmd.Parameters.AddWithValue("@State", c.State);
        PersonAddressCmd.Parameters.AddWithValue("@Street", c.Zipcode);
       
        return PersonAddressCmd;
    }


    public SqlCommand WriteDonation()
    {
        string sqlDonation ="Insert into Person.Donation(DonationDate, DonationAmount, PersonKey, EmployeeKey, DonationConfirmDate) Values(@DonationDate, @DonationAmount, @EmployeeKey, @DonationConfirmDate, ident_Current('Person'))";
          
        SqlCommand regDonationCmd = new SqlCommand(sqlDonation, connect);
        regDonationCmd.Parameters.AddWithValue("@DonationDate", c.DonationDate);
        regDonationCmd.Parameters.AddWithValue("@DonationAmount", c.DonationAmount);
        
        
        return regDonationCmd;
    }


    public void WriteCustomer(Person c)
    {
        this.c = c;
        
        SqlTransaction tran = null;
        
        SqlCommand pCmd = WritePerson();
        SqlCommand vCmd = WritePersonAddress();
        SqlCommand rCmd = WriteDonation();

        connect.Open();
        try
        {
            tran = connect.BeginTransaction();
            pCmd.Transaction = tran;
            vCmd.Transaction = tran;
            rCmd.Transaction = tran;
            pCmd.ExecuteNonQuery();
            vCmd.ExecuteNonQuery();
            rCmd.ExecuteNonQuery();
            tran.Commit();
        }
        catch (Exception ex)
        {
            tran.Rollback();
            throw ex;
        }
        finally
        {
            connect.Close();
        }
    }
}
