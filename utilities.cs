using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Nursityy
{
    public class utilities
    {
        public static string hashPassword(string senha) 
        {
            SHA1CryptoServiceProvider sha1 = new();

            byte[] senha_bytes = Encoding.ASCII.GetBytes(senha);
            byte [] bytes_encriptados = sha1.ComputeHash(senha_bytes);
            return Convert.ToBase64String(bytes_encriptados);

            
        }

        public static Dictionary<int, string> getSlots()
        {
            Dictionary<int, string> slots = new Dictionary<int, string>();
            slots.Add(1, "Slot 1: 6:00 - 6:30");
            slots.Add(2, "Slot 2: 6:30 - 7:00");
            slots.Add(3, "Slot 3: 7:00 - 7:30");
            slots.Add(4, "Slot 4: 7:30 - 8:00");
            slots.Add(5, "Slot 5: 8:00 - 8:30");
            slots.Add(6, "Slot 6: 8:30 - 9:00");
            slots.Add(7, "Slot 7: 9:00 - 9:30");
            slots.Add(8, "Slot 8: 9:30 - 10:00");
            slots.Add(9, "Slot 9: 10:00 - 10:30");
            slots.Add(10, "Slot 10: 10:30 - 11:00");
            slots.Add(11, "Slot 11: 11:00 - 11:30");
            slots.Add(12, "Slot 12: 11:30 - 12:00");
            slots.Add(13, "Slot 13: 13:00 - 13:30");
            slots.Add(14, "Slot 14: 13:30 - 14:00");
            slots.Add(15, "Slot 15: 14:00 - 14:30");
            slots.Add(16, "Slot 16: 14:30 - 15:00");
            slots.Add(17, "Slot 17: 15:00 - 15:30");
            slots.Add(18, "Slot 18: 15:30 - 16:00");
            slots.Add(19, "Slot 19: 16:00 - 16:30");
            slots.Add(20, "Slot 20: 16:30 - 17:00");
            slots.Add(21, "Slot 21: 17:00 - 17:30");
            slots.Add(22, "Slot 22: 17:30 - 18:00");

            return slots;
        }

        public static void criarAdm(string senha)
        {

            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();

            command.CommandText = "INSERT INTO [User] (user_nome, user_senha) VALUES (@usuario,@senha)";
            command.Parameters.AddWithValue("@usuario","admin");
            command.Parameters.AddWithValue("@senha", hashPassword(senha));

            con.Open();

            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }

            con.Close();
        }
    }
}
