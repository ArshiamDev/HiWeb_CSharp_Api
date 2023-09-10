using HiWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GiftController : ControllerBase
    {
        context context = new context();
        [HttpGet]
        public List<Gift> GetGifts()
        {
            return context.gifts.ToList();
        }
        public bool setDate(string date , int remainNet , int totalNet , int giftnet)
        {
            try
            {
                DateTime time = Convert.ToDateTime(date).Date;

                var q = (from a in context.gifts
                         where a.Id == 1
                         select a).FirstOrDefault();
                if (q != null)
                {
                    q.lastGiftTimeDate = time;
                    q.lastGiftTimeString = date;
                    q.totalNet = totalNet;
                    q.remainNet = remainNet;
                    q.giftNet = giftnet;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}