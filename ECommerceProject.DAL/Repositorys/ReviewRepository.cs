using ECommerceProject.DAL.Data;
using ECommerceProject.DAL.Entities;
using ECommerceProject.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Repositorys
{
    public class ReviewRepository : IReviewRepository
    {
        ECommerceDataContext _context;
        public ReviewRepository(ECommerceDataContext context)
        {
            _context = context;
        }
        public bool AddReview(Review review)
        {
            _context.Reviews.Add(review);
            return _context.SaveChanges()>0;
        }

        public bool DeleteReview(int reviewId)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.ReviewId == reviewId);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                return _context.SaveChanges() > 0;
            }
            else return false;
        }

        public List<Review> GetAllReviews()
        {
            var review = _context.Reviews
                .Include(r => r.User)
                .Include(r=>r.Product)
                .ToList();
            return review;
        }

        public Review GetReviewById(int reviewId)
        {
           var review= _context.Reviews.Where(r=>r.ReviewId == reviewId)
                .Include(r=> r.Product)
                .Include(r=>r.UserId)
                .FirstOrDefault();
            return review;
        }

        public bool UpdateReview(Review review)
        {
            _context.Reviews.Update(review);
            return _context.SaveChanges() > 0;
        }
    }
}
