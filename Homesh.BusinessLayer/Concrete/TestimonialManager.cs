using Homesh.BusinessLayer.Abstract;
using Homesh.DataAccessLayer.Abstract;
using Homesh.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homesh.BusinessLayer.Concrete
{
    public class TestimonialManager:ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialDal.Add(entity);
        }

        public void TDelete(string id)
        {
            _testimonialDal.Delete(id);
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial TGetById(string id)
        {
            return _testimonialDal.GetById(id);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
