﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NoStop.MODEL;

namespace NoStop.VIEW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrição da Página.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Informações de Contato.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario u)
        {
            using (noStopEntities dc = new noStopEntities())
            {
                var v = dc.Usuario.Where(a => a.Email.Equals(u.Email) && a.Senha.Equals(u.Senha)).FirstOrDefault();
                if (v != null)
                {
                    Session["usuarioLogadoID"] = v.ID.ToString();
                    Session["ID"] = v.ID;
                    Session["nomeUsuarioLogado"] = v.Nome.ToString();
                    Session["Role"] = v.Roles.ToString();
                    Session["UserData"] = v;
                    ViewBag.Message = null;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = "Email ou senha incorreto(s)";
                }
            }
            return View(u);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Erro()
        {
            return View();
        }
    }
}