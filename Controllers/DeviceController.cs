using UsersourcedUnitTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UsersourcedUnitTesting.Controllers
{
    public class DeviceController : ApiController
    {
        Device[] devices = new Device[] 
        { 
            new Device { Id = 1, OSVersion = "17", Model = "SAMSUNG-SM-G730A / samsung / samsung", Architecture = "armeabi-v7a" }, 
            new Device { Id = 1, OSVersion = "18", Model = "SAMSUNG-SM-G730A / samsung / samsung", Architecture = "armeabi-v7a" }, 
            new Device { Id = 1, OSVersion = "19", Model = "SAMSUNG-SM-G730A / samsung / samsung", Architecture = "armeabi-v7a" }
        };

        public IEnumerable<Device> GetAllDevices()
        {
            return devices;
        }

        public IHttpActionResult GetDevice(int id)
        {
            var product = devices.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
