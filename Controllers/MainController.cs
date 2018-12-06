using System;
using System.Collections.Generic;
using System.Data;
using DojoLeague.Models;
using DojoLeague.Factory;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Dapper;

namespace DojoLeague.Models
{
    public class MainController : Controller
    {
        // creates the factory object for the Ninja
        private readonly NinjaFactory _ninjaFactory;
        private readonly DojoFactory _dojoFactory;
        public MainController(NinjaFactory nFactory, DojoFactory dFactory)
        {
            // Instantiate a NinjaFactory & DojoFactory object that is ummutable (READONLY)
            // This establishes the initial DB connection.
            _ninjaFactory = nFactory;
            _dojoFactory = dFactory;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            // Viewbag's the Ninja list on the Index view
            ViewBag.allNinjas = _ninjaFactory.NinjaWithDojos();
            return View("Index");
        }
        [HttpGet("Dojos")]
        public IActionResult Dojos()
        {
            // Viewbags the Dojo list on the Dojos view
            ViewBag.allDojos = _dojoFactory.DojoList();
            return View("Dojos");
        }

        // Update Ninja code to only contain a single ninja once DB connection established
        [HttpGet("ninjas/{id}")]
        public IActionResult DisplayNinja(int id)
        {
            var ninja = _ninjaFactory.NinjaFind(id);
            return View("Ninja", ninja);
        }
        [HttpGet("dojo/{dojo_id}")]
        public IActionResult DisplayDojo(int dojo_id)
        {
            //runs the DojoFind query from DojoFactory.cs
            var dojo = _dojoFactory.DojoFind(dojo_id);
            ViewBag.ninjaDojoList = _ninjaFactory.FindNinjasInDojo(dojo_id);
            ViewBag.rougeNinjas = _ninjaFactory.FindRogueNinjas();
            //if query returns null, then redirect to dojos.
            if(dojo == null)
            {
                return RedirectToAction("Dojos");
            } 
            return View("Dojo", dojo);
        }

        // Creates a new ninja and adds them to the DB
        [HttpPost("CreateNinja")]
        public IActionResult CreateNinja(Ninja ninja)
        {
            // Checks to see if submitted information is valid
            if(ModelState.IsValid)
            {
                _ninjaFactory.AddNewNinja(ninja);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.allNinjas = _ninjaFactory.NinjaWithDojos();
                return View("Index");
            }
        }

        // Creates a new dojo and adds it to the DB
        [HttpPost("CreateDojo")]
        public IActionResult CreateDojo(Dojo dojo)
        {
            // Checks to see if submitted information is valid
            if(ModelState.IsValid)
            {
                _dojoFactory.AddNewDojo(dojo);
                return RedirectToAction("Dojos");
            }
            else
            {
                ViewBag.allDojos = _dojoFactory.DojoList();
                return View("Dojos");
            }
        }

        // Update Banish Code here
        [HttpGet("banish/{dojo_id}/{ninja_id}")]
        public IActionResult BanishNinja(int dojo_id, int ninja_id)
        {
            _dojoFactory.Banish(ninja_id);
            return RedirectToAction("DisplayDojo", dojo_id);
        }
        
        // Recruits a ninja to the active dojo
        [HttpGet("recruit/{dojo_id}/{ninja_id}")]
        public IActionResult RecruitNinja(int dojo_id, int ninja_id)
        {
            _dojoFactory.Recruit(dojo_id, ninja_id);
            return RedirectToAction("DisplayDojo", dojo_id);
        }
    }
}