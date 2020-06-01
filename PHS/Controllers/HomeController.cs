using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PHS.Models;

namespace PHS.Controllers
{
    public class HomeController : Controller
    {

        PersonContext db = new PersonContext();

        public ActionResult Index()
        {

            IEnumerable<Administrator> administrators = db.Administrators;
            IEnumerable<Doctor> doctors = db.Doctors;
            IEnumerable<Pacient> pacients = db.Pacients;

            ViewBag.Administrators = administrators;
            ViewBag.Doctors = doctors;
            ViewBag.Pacients = pacients;

            return View();
        }

        public ActionResult NavD1()
        {

            IEnumerable<Administrator> administrators = db.Administrators;
            IEnumerable<Doctor> doctors = db.Doctors;
            IEnumerable<Pacient> pacients = db.Pacients;

            ViewBag.Administrators = administrators;
            ViewBag.Doctors = doctors;
            ViewBag.Pacients = pacients;

            return View("Doc");
        }
        public ActionResult NavD2()
        {

            IEnumerable<Administrator> administrators = db.Administrators;
            IEnumerable<Doctor> doctors = db.Doctors;
            IEnumerable<Pacient> pacients = db.Pacients;

            ViewBag.Administrators = administrators;
            ViewBag.Doctors = doctors;
            ViewBag.Pacients = pacients;

            return View("DocPac");
        }
        public ActionResult NavD3()
        {

            IEnumerable<Administrator> administrators = db.Administrators;
            IEnumerable<Doctor> doctors = db.Doctors;
            IEnumerable<Pacient> pacients = db.Pacients;

            ViewBag.Administrators = administrators;
            ViewBag.Doctors = doctors;
            ViewBag.Pacients = pacients;

            return View("DocPacPre");
        }
        public ActionResult Regist()
        {

            IEnumerable<Administrator> administrators = db.Administrators;
            IEnumerable<Doctor> doctors = db.Doctors;
            IEnumerable<Pacient> pacients = db.Pacients;

            ViewBag.Administrators = administrators;
            ViewBag.Doctors = doctors;
            ViewBag.Pacients = pacients;

            return View();
        }
        public ActionResult Change()
        {

            IEnumerable<Administrator> administrators = db.Administrators;
            IEnumerable<Doctor> doctors = db.Doctors;
            IEnumerable<Pacient> pacients = db.Pacients;

            ViewBag.Administrators = administrators;
            ViewBag.Doctors = doctors;
            ViewBag.Pacients = pacients;

            return View("Change");
        }
        public ActionResult Pac()
        {

            IEnumerable<Administrator> administrators = db.Administrators;
            IEnumerable<Doctor> doctors = db.Doctors;
            IEnumerable<Pacient> pacients = db.Pacients;

            ViewBag.Administrators = administrators;
            ViewBag.Doctors = doctors;
            ViewBag.Pacients = pacients;

            return View("Pac");
        }

        [HttpPost]
        public ActionResult Open(string Pass, string Log)
        {
            foreach (Administrator a in db.Administrators)
            {
                if (a.login == Log && a.password == Pass)
                {
                    ViewBag.PersonName = a.NSP;
                    ViewBag.PersonLogin = Log;
                    return View("Admin");
                }
            }
            foreach (Doctor a in db.Doctors)
            {
                if (a.login == Log && a.password == Pass)
                {
                    ViewBag.PersonName = a.NSP;
                    ViewBag.PersonLogin = Log;

                    return View("Doc");
                }
            }
            foreach (Pacient a in db.Pacients)
            {
                if (a.login == Log && a.password == Pass)
                {
                    ViewBag.PersonName = a.NSP;
                    ViewBag.PersonLogin = Log;
                    return View("Pac");
                }
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult AddDoctor(string N, string S, string P, string Mail, string Password, string Number, Doctor doctor)
        {
            if (N != "" && P != "" && S != "" && Mail != "" && Password != "" && Number != "")
            {
                doctor.NSP = S + " " + N + " " + P;
                doctor.mail = Mail;
                doctor.passport = Convert.ToInt32(Number);
                doctor.password = Password;
                doctor.login = "doc" + "0" + Convert.ToInt32(DateTime.Now.Hour) + Convert.ToInt32(DateTime.Now.Day) + Convert.ToInt32(DateTime.Now.Minute);
                doctor.working = "Педіатр";

                db.Doctors.Add(doctor);

                db.SaveChanges();
            }
            return View("Admin");
        }
        [HttpPost]
        public ActionResult AddPreparation(string N1, string N2, string N3, string N4, string N5, string N6, string N7, Preparation preparation)
        {
            if (N1 != "" && N2 != "" && N3 != "" && N4 != "" && N5 != "" && N6 != "" && N7 != "")
            {
                preparation.name = N1;
                preparation.text = N2 + " " + N3 + " " + N4 + " " + N5 + " " + N6 + " " + N7;
                db.Preparations.Add(preparation);

                db.SaveChanges();
            }
            return View("Admin");
        }
        [HttpPost]
        public ActionResult DeleteDoctor(string Login)
        {
            foreach (Doctor a in db.Doctors)
            {
                if (a.login == Login)
                {
                    db.Doctors.Remove(a);
                    break;
                }
            }
            db.SaveChanges();
            return View("Admin");
        }
        [HttpPost]
        public ActionResult DeletePreparation(string Name)
        {
            foreach (Preparation a in db.Preparations)
            {
                if (a.name == Name)
                {
                    db.Preparations.Remove(a);
                    break;
                }
            }
            db.SaveChanges();
            return View("Admin");
        }
        [HttpPost]
        public ActionResult OpenPacient(string Login)
        {
            foreach (Pacient a in db.Pacients)
            {
                if (a.login == Login)
                {
                    ViewBag.PersonName = a.NSP;
                    ViewBag.PersonLogin = Login;
                    return View("DocPac");
                }
            }
            return View("Doc");
        }
        [HttpPost]
        public ActionResult Register(Pacient pacient, string N, string S, string P, string pass1, string pass2, string mail, string numDecl, string passport)
        {
            if (N != "" && P != "" && S != "" && mail != "" && pass1 != "" && pass1 == pass2)
            {
                pacient.NSP = S + " " + N + " " + P;
                pacient.password = pass1;
                pacient.mail = mail;
                pacient.login = "pac" + "0" + Convert.ToInt32(passport);
                foreach (Declaration a in db.Declarations)
                {
                    if (a.number == Convert.ToInt32(numDecl))
                    {
                        pacient.DoctorId = a.DoctorId;
                        break;
                    }
                }
                db.Pacients.Add(pacient);

                db.SaveChanges();
            }
            return View("Regist");
        }
        [HttpPost]
        public ActionResult Call()
        {
            @ViewBag.DP1 = "Родгово Олександр Сергійович";
            @ViewBag.DT1 = "02.06.2020";
            @ViewBag.DT2 = "9:00";
            return View("Pac");
        }
    }
}