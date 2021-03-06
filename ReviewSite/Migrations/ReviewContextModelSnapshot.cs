﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewSite;

namespace ReviewSite.Migrations
{
    [DbContext(typeof(ReviewContext))]
    partial class ReviewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewSite.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, Description = "C# is a Microsoft coding language.", Name = "C#" },
                        new { CategoryId = 2, Description = "Python is, well, Python.", Name = "Python" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvgRating");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Duration");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Overview");

                    b.Property<string>("StartDate");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.HasKey("CourseId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");

                    b.HasData(
                        new { CourseId = 1, CategoryId = 1, Duration = "16 Weeks", ImageURL = "/Images/machinelearning.jpg", Overview = "Learn to use machine learning to your advantage.", StartDate = "August 2nd, 2019", Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Title = "Machine Learning" },
                        new { CourseId = 2, CategoryId = 2, Duration = "12 Weeks", ImageURL = "/Images/pythonforeveryone.jpg", Overview = "It really is for everybody!", StartDate = "August 3rd, 2019", Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Title = "Python For Everybody" },
                        new { CourseId = 3, CategoryId = 1, Duration = "14 Weeks", ImageURL = "/Images/wwkd.jpg", Overview = "What would Kyle do?", StartDate = "August 4th, 2019", Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Title = "WWKD?" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.UserReview", b =>
                {
                    b.Property<int>("UserReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<int>("CourseId");

                    b.Property<decimal>("Rating");

                    b.Property<string>("UserName");

                    b.HasKey("UserReviewId");

                    b.HasIndex("CourseId");

                    b.ToTable("UserReviews");

                    b.HasData(
                        new { UserReviewId = 1, Comment = "Its free!", CourseId = 1, Rating = 3.3m, UserName = "MoocJunkie" },
                        new { UserReviewId = 2, Comment = "You get what you pay for and it's free.", CourseId = 1, Rating = 4.1m, UserName = "SwagYoloFleekDabs" },
                        new { UserReviewId = 3, Comment = "The instructors are racist.", CourseId = 1, Rating = 3.9m, UserName = "xXx_DragonSlayer_xXx" },
                        new { UserReviewId = 4, Comment = "The instructors love you like their own family!", CourseId = 2, Rating = 4.9m, UserName = "JoeLovesFishing_USA" },
                        new { UserReviewId = 5, Comment = "If I could experience Groundhog Day here, I'd still never get enough.", CourseId = 2, Rating = 5.0m, UserName = "elDiablo1992" },
                        new { UserReviewId = 6, Comment = "This place attracts weirdos.", CourseId = 2, Rating = 4.1m, UserName = "W3CanC0d31T" },
                        new { UserReviewId = 7, Comment = "I'd rather pay for college than this.", CourseId = 3, Rating = 2.2m, UserName = "anegronjr" },
                        new { UserReviewId = 8, Comment = "The carpets smell like urine.", CourseId = 3, Rating = 1.7m, UserName = "alexanderjalbright" },
                        new { UserReviewId = 9, Comment = "The coffee has a peculiar taste.", CourseId = 3, Rating = 2.2m, UserName = "khanishvili" },
                        new { UserReviewId = 10, Comment = "PICK UP YOUR STARBUCKS CUPS!", CourseId = 3, Rating = 2.3m, UserName = "jen3ten" },
                        new { UserReviewId = 11, Comment = "I've learned more from 6th graders.", CourseId = 3, Rating = 2.0m, UserName = "MaryMcGeary" },
                        new { UserReviewId = 12, Comment = "I can't see the board.", CourseId = 3, Rating = 1.5m, UserName = "mroyski" },
                        new { UserReviewId = 13, Comment = "(╯°□°）╯︵ ┻━┻", CourseId = 3, Rating = 3.0m, UserName = "aldenmolina" },
                        new { UserReviewId = 14, Comment = "I think we can all agree that what Kyle would do and what Kyle will do are two different things.", CourseId = 3, Rating = 3.0m, UserName = "JoeScheiman" },
                        new { UserReviewId = 15, Comment = "I'm just here for the oatmeal.", CourseId = 3, Rating = 3.0m, UserName = "mew101" }
                    );
                });

            modelBuilder.Entity("ReviewSite.Models.Course", b =>
                {
                    b.HasOne("ReviewSite.Models.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReviewSite.Models.UserReview", b =>
                {
                    b.HasOne("ReviewSite.Models.Course", "Course")
                        .WithMany("UserReviews")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
