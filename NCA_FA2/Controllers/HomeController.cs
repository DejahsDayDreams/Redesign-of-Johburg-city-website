
using Microsoft.AspNetCore.Mvc;
using NCA_FA2.Models;
using System.Diagnostics;

namespace NCA_FA2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
          
            return View();
        }

        // Action for submitting complaints
        [HttpPost]
        public IActionResult SubmitComplaint(FeedbackViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save the complaint data to the database using your ComplaintModel
                // For example:
                var complaintModel = new ComplaintModel
                {
                    Complaint_Name = model.Complaint_Name,
                    Complaint_Email = model.Complaint_Email,
                    Complaint_Phone = model.Complaint_Phone,
                    Complaint_Text = model.Complaint_Text
                };

                int rowsAffected = complaintModel.SaveComplaintDetails();

                // Redirect to a thank you page or show a success message
                return RedirectToAction("ThankYou");
            }

            // If the model is not valid, return to the same view with validation errors
            return View(model);
        }

        // Action for submitting compliments
        [HttpPost]
        public IActionResult SubmitCompliment(FeedbackViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save the compliment data to the database using your ComplimentModel
                // For example:
                var complimentModel = new ComplimentModel
                {
                    Compliment_Name = model.Compliment_Name,
                    Compliment_Email = model.Compliment_Email,
                    Compliment_Phone = model.Compliment_Phone,
                    Compliment_Text = model.Compliment_Text
                };

                int rowsAffected = complimentModel.SaveComplimentDetails();

                // Redirect to a thank you page or show a success message
                return RedirectToAction("ThankYou");
            }

            // If the model is not valid, return to the same view with validation errors
            return View(model);
        }

        public IActionResult ThankYou()
        {
            return View();
        }



        public IActionResult AboutTheCity()
        {
            return View();
        }

        public IActionResult CityServices()
        {
            return View();
        }

        public IActionResult KeyDocuments()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}