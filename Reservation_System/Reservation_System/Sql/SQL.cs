using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_System
{
    class SQL
    {
        public MySqlConnection MySqlConnection()
        {
            string server = "10.12.132.34";
            string database = "Ville_Kokkarinen_OHTU";
            string uid = "p119980";
            string password = "12345";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
        public MySqlCommand MySqlLogin(string user, string password, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from USERS where U_USERNAME=@user and U_PASSWORD=@password", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            return cmd;
        }

        public MySqlCommand SelectUserByUserNameAndEmail(string user, string email, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from USERS where U_USERNAME=@user and U_EMAIL=@email", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@email", email);

            return cmd;
        }

        public MySqlCommand MySqlChangePassword(string user, byte[] newpassword, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE USERS SET U_PASSWORD =@newpassword where U_USERNAME=@user", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@newpassword", newpassword);

            return cmd;
        }

        public MySqlCommand MySqlChangeEmail(string user, string newemail, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE USERS SET U_PASSWORD =@newpassword where U_USERNAME=@user", connection);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@newpassword", newemail);

            return cmd;
        }

        public MySqlCommand MySqlGetAvailableItems(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("select * from ITEMS where ITEMS.I_STATE=1", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetItemTypes(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("select * from ITEMTYPE ORDER BY IT_ID", connection);            
            return cmd;
        }

        public MySqlCommand MySqlSelectLoanableItems(MySqlConnection connection)
        {            
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ITEMS WHERE (ITEMS.I_STATE = 0 OR ITEMS.I_STATE = 2)", connection);
            return cmd;
        }

        public MySqlCommand MySqlLoanItems(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE ITEMS SET I_STATE = 1 WHERE I_ID =@itemid;INSERT INTO RESERVATION (R_USER) VALUES (@user); INSERT INTO RESERVATIONROWS (RR_R_ID, RR_USER, RR_ITEM, RR_RETURNDATE, RR_PENDING_LOAN) VALUES (LAST_INSERT_ID(), @user, @itemid, @returndate, 1)", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetItemTypeName(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT IT_NAME FROM ITEMTYPE WHERE IT_ID =@ITEMTYPEID", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetItemStateName(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT IS_NAME FROM ITEMSTATE WHERE IS_ID =@ITEMSTATEID", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetReservationDateForItem(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT RR_RESERVATIONDATE FROM RESERVATIONROWS WHERE RR_ITEM =@itemid AND RR_RETURNED = 0 AND RR_PRE_RESERVATION = 1 AND RR_PENDING_LOAN = 0", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetReturnDateForItem(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT RR_RETURNDATE FROM RESERVATIONROWS WHERE RR_ITEM =@ITEMID AND RR_RETURNED = 0 AND RR_USER =@USER", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetAllItems(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("Select * from ITEMS ORDER BY I_ID", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetUserReservations(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ITEMS, RESERVATION, RESERVATIONROWS WHERE ITEMS.I_STATE = 2 AND RESERVATION.R_USER =@USER AND RESERVATIONROWS.RR_R_ID = RESERVATION.R_ID AND RESERVATIONROWS.RR_ITEM = ITEMS.I_ID AND RESERVATIONROWS.RR_USER =@USER AND RESERVATIONROWS.RR_RETURNED = 0 AND RR_PENDING_LOAN = 0 AND RR_PENDING_RETURN = 0 AND RR_PRE_RESERVATION = 1;", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetUpdateReservationsToLoans(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE ITEMS i, RESERVATIONROWS rr SET i.I_STATE = 1, rr.RR_PENDING_LOAN = 1, rr.RR_PRE_RESERVATION = 0 WHERE rr.RR_PRE_RESERVATION = 1 AND i.I_STATE = 2 AND rr.RR_RESERVATIONDATE < NOW();", connection);
            return cmd;
        }

        public MySqlCommand MySqlReserveItems(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE ITEMS SET I_STATE = 2 WHERE I_ID =@itemid;INSERT INTO RESERVATION (R_USER) VALUES (@user); INSERT INTO RESERVATIONROWS (RR_R_ID, RR_USER, RR_ITEM, RR_RESERVATIONDATE, RR_RETURNDATE, RR_PENDING_LOAN, RR_PRE_RESERVATION) VALUES (LAST_INSERT_ID(), @user, @itemid, @startdate, @returndate, 0, 1)", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetUserLoans(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ITEMS, RESERVATION, RESERVATIONROWS WHERE ITEMS.I_STATE = 1 AND RESERVATION.R_USER =@USER AND RESERVATIONROWS.RR_R_ID = RESERVATION.R_ID AND RESERVATIONROWS.RR_ITEM = ITEMS.I_ID AND RESERVATIONROWS.RR_USER =@USER AND RESERVATIONROWS.RR_RETURNED = 0 AND RR_PENDING_LOAN = 0 AND RR_PENDING_RETURN = 0", connection);
            return cmd;
        }

        public MySqlCommand MySqlRequestItemReturn(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE RESERVATIONROWS SET RR_PENDING_RETURN = 1 WHERE RESERVATIONROWS.RR_PENDING_RETURN = 0 AND RR_USER =@USER AND RR_ITEM =@itemid", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetItemLoanerAndReturnDate(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT user.U_USERNAME, rr.RR_RETURNDATE FROM USERS user, RESERVATIONROWS rr WHERE RR_ITEM =@itemid AND RR_USER = user.U_ID", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetPendingLoans(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT I_ID, I_NAME, I_TYPE, I_STATE FROM ITEMS, RESERVATIONROWS WHERE I_ID = RR_ITEM AND RR_RETURNED = 0 AND RR_PENDING_LOAN = 1 AND RR_PENDING_RETURN = 0 AND RR_PRE_RESERVATION = 0", connection);
            return cmd;
        }

        public MySqlCommand MySqlGetPendingReturns(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT I_ID, I_NAME, I_TYPE, I_STATE FROM ITEMS, RESERVATIONROWS WHERE I_ID = RR_ITEM AND RR_RETURNED = 0 AND RR_PENDING_LOAN = 0 AND RR_PENDING_RETURN = 1", connection);
            return cmd;
        }

        public MySqlCommand MySqlAcceptPendingReturns(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE ITEMS SET I_STATE = 0 WHERE I_ID =@itemid;UPDATE RESERVATIONROWS SET RR_PENDING_RETURN = 0, RR_RETURNED = 1 WHERE RR_ITEM =@itemid AND RR_PENDING_RETURN = 1", connection);
            return cmd;
        }

        public MySqlCommand MySqlDenyPendingReturns(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE ITEMS SET I_STATE = 0 WHERE I_ID =@itemid; DELETE rows, res FROM RESERVATIONROWS rows JOIN RESERVATION res ON rows.RR_R_ID = res.R_ID WHERE RR_USER =@user AND RR_ITEM =@itemid AND RR_PENDING_LOAN = 1", connection);
            return cmd;
        }

        public MySqlCommand MySqlAcceptPendingLoans(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE ITEMS SET I_STATE = 1 WHERE I_ID =@itemid;UPDATE RESERVATIONROWS SET RR_PENDING_LOAN = 0 WHERE RR_ITEM =@itemid AND RR_PENDING_LOAN = 1", connection);
            return cmd;
        }

        public MySqlCommand MySqlAddNewItem(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO ITEMS (I_NAME, I_STATE, I_TYPE) VALUES (@name, 1, @TYPE)", connection);
            return cmd;
        }

        public MySqlCommand MySqlAddNewItemType(MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO ITEMTYPE (IT_NAME) VALUES (@name)", connection);
            return cmd;
        }

    }
}
