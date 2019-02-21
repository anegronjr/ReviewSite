﻿using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewModelTests
    {
        Review underTest;

        public ReviewModelTests()
        {
            underTest = new Review("Machine Learning", 1, "Algorithms", "./images/MachineLearning.jpg", "It was really awesome", "It awesome");
        }

        [Fact]
        public void Review_Has_Title()
        {
            string expected = "Machine Learning";

            var result = underTest.Title;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Id()
        {
            int expected = 1;

            var result = underTest.Id;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Category()
        {
            string expected = "Algorithms";

            var result = underTest.Category;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Image_URL()
        {
            string expected = "./images/MachineLearning.jpg";

            var result = underTest.ImageURL;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Content()
        {
            string expected = "It was really awesome";

            var result = underTest.Content;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Summary()
        {
            string expected = "It awesome";

            var result = underTest.Summary;

            Assert.Equal(expected, result);
        }
    }
}
