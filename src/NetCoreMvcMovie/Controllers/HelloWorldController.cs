﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreMvcMovie.Controllers
{
	public class HelloWorldController : Controller
	{
		// 
		// GET: /HelloWorld/

		public string Index()
		{
			return "This is my default action...";
		}

		// 
		// GET: /HelloWorld/Welcome/ 

		public string Welcome(string name, int numTimes = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}");
		}
	}
}
