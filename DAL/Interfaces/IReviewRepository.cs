using ECommerceProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.DAL.Interfaces
{
    public interface IReviewRepository
    {
        List<Review> GetAllReviews();
        Review GetReviewById(int reviewId);
        bool AddReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(int reviewId);
    }
}
