using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EV1_T4FN_Carlo_Renato_Vivanco_Palomino.Models;

namespace EV1_T4FN_Carlo_Renato_Vivanco_Palomino.Controllers
{
    public class ComidaRapidaController : Controller
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KFCKentucky"].ConnectionString);

        // GET: ComidaRapida
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }

            ViewBag.mensaje = "";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Usuario values(@dni,@nom,@fecNac,@email,@tel)", con);
                
                cmd.Parameters.AddWithValue("@dni", usuario.dni);
                cmd.Parameters.AddWithValue("@nom", usuario.nombre);
                cmd.Parameters.AddWithValue("@fecNac", usuario.fecNac);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@tel", usuario.telefono);

                ViewBag.mensaje = cmd.ExecuteNonQuery().ToString() + "registro agregado correctamente";

            }
            catch(SqlException e)
            {
                ViewBag.mensaje = e.Message;
            }
            finally
            {
                con.Close();
            }

            return View(usuario);
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View(new Usuario());
        }
    }
}