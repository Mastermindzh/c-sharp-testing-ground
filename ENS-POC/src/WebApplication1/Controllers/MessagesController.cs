using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

	[Route("api/[controller]")]
	public class MessagesController : Controller
	{

		SqlConnection conn = new SqlConnection();

		public MessagesController() {
			conn.ConnectionString = "Data Source=LIESHORI-WIN10\\SQLEXPRESS;User ID=sa;Password=Welkom01!;Database=ENS";
		}

		// GET api/values
		[HttpGet]
		public string Get()
		{
			try
			{
				conn.Open();
				conn.Close();
				return "Connection to the database was made succesfully";
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}


		[HttpGet("{name}")]
		public List<message> GetObjectDB(string name)
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataReader reader;
			List<message> msgs = new List<message>();

			cmd.CommandText = "SELECT * FROM Message where Recipient_username = @name";
			SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 200);
			nameParam.Value = name;
			cmd.Parameters.Add(nameParam);


			try
			{
				conn.Open();
				cmd.Connection = conn;
				cmd.Prepare();
				reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					msgs.Add(new message() { MessageID = reader.GetInt32(0), Message = reader.GetString(2), Recipient_username = reader.GetString(1), Processed = reader.GetBoolean(3) });
				}
			}
			catch { }

			return msgs;
		}

		// POST api/values
		[HttpPost]
		public string Post([FromBody]message msg)
		{
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "INSERT INTO Message (Recipient_username, message) VALUES (@username,@message)";
			SqlParameter usernameParam = new SqlParameter("@username", SqlDbType.VarChar, 200);
			SqlParameter messageParam = new SqlParameter("@message", SqlDbType.Text, 600);
			usernameParam.Value = msg.Recipient_username;
			messageParam.Value = msg.Message;
			cmd.Parameters.Add(usernameParam);
			cmd.Parameters.Add(messageParam);

			try
			{
				conn.Open();
				cmd.Connection = conn;
				cmd.Prepare();
				cmd.ExecuteNonQuery();
				return "Sucessfully added message.";
			}
			catch (Exception ex) {
				return "Can not add record because: " + ex.ToString();
			}
		}

		// Should use put to update records.
		[HttpGet("process/{message_id}")]
		public string Process(int message_id) {
			SqlCommand cmd = new SqlCommand();

			cmd.CommandText = "UPDATE Message set Processed = 1 where MessageID = @message_id";
			SqlParameter idParam = new SqlParameter("@message_id", SqlDbType.Int, 0);
			
			idParam.Value = message_id;
			cmd.Parameters.Add(idParam);
			
			try
			{
				conn.Open();
				cmd.Connection = conn;
				cmd.Prepare();
				cmd.ExecuteNonQuery();
				return "Sucessfully processed message.";
			}
			catch (Exception ex)
			{
				return "Can not process message because: " + ex.ToString();
			}
		}
	}
}
