using Microsoft.AspNetCore.Mvc;
using PlantItOut.Data;
using PlantItOut.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PlantItOut.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace PlantItOut.Controllers
{
    /*[Authorize]*/
    public class TagController : Controller
    {
        private PlantDbContext context;
        public TagController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        //GET
        public IActionResult Index()
        {
            List<Tag> tags = context.Tags.ToList();
            return View(tags);
        }

        /*[Authorize(Roles = "Admin")]*/
        public IActionResult Add()
        {
            Tag tag = new Tag();
            return View(tag);
        }

        [HttpPost]
        /*[Authorize(Roles = "Admin")]*/
        public IActionResult Add(Tag tag)
        {
            if (ModelState.IsValid)
            {
                context.Tags.Add(tag);
                context.SaveChanges();
                return Redirect("/Tag/");
            }
            return View("Add", tag);
        }

        /*[Authorize(Roles = "Admin")]*/
        public IActionResult AddPlant(int id)
        {
            Plant thePlant = context.Plants.Find(id);
            List<Tag> plantTags = context.Tags.ToList();

            AddPlantTagViewModel tagViewModel = new AddPlantTagViewModel(thePlant, plantTags);
            return View(tagViewModel);
        }

        [HttpPost]
        /*[Authorize(Roles = "Admin")]*/
        public IActionResult AddPlant(AddPlantTagViewModel tagViewModel)
        {
            if (ModelState.IsValid)
            {
                int plantId = tagViewModel.PlantId;
                int tagId = tagViewModel.TagId;

                List<PlantTag> exsistingTags = context.PlantTags
                    .Where(pt => pt.PlantId == plantId)
                    .Where(pt => pt.TagId == tagId)
                    .ToList();
                if (exsistingTags.Count == 0)
                {
                    PlantTag plantTag = new PlantTag
                    {
                        PlantId = plantId,
                        TagId = tagId
                    };
                    context.PlantTags.Add(plantTag);
                    context.SaveChanges();
                }
                return Redirect("/Plants/Detail" + plantId);
            }
            return View(tagViewModel);
        }

        /*public IActionResult Detail(int id)
        {
            List<PlantTag> plantTags = context.PlantTags
                .Where(pt => pt.TagId == id)
                .Include(pt => pt.Plant)
                .Include(pt => pt.Tag)
                .ToList();

            return View(plantTags);
        }*/

        public IActionResult Delete(int[] tagIds)
        {
            foreach(int tagId in tagIds)
            {
                Tag tags = context.Tags.Find(tagId);
                context.Tags.Remove(tags);
            }
            context.SaveChanges();
            return View();
        }
    }
}
