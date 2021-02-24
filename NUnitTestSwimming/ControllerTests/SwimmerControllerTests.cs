﻿using ADO.BL.Interfaces;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using SwimmingWebApp.Controllers;

namespace NUnitTestSwimming.ControllerTests
{
    public class SwimmerControllerTests
    {
        [Test]
        public void SwimmerContoller_InstanceofViewResult()
        {
            //arrange
            int page = 1;
            var serviceMock = new Mock<ISwimmerService>();
            serviceMock.Setup(a => a.SelectSwimmers());
            SwimmerController controller = new SwimmerController(serviceMock.Object);

            //act
            var result = controller.Index(page);
            var viewResult = Is.TypeOf<ViewResult>();
            Assert.That(result, viewResult);
        }

        [Test]
        public void SwimmerController_Result_ShouldNotNull()
        {
            //arrange
            int page = 1;
            var serviceMock = new Mock<ISwimmerService>();
            serviceMock.Setup(a => a.SelectSwimmers());
            SwimmerController controller = new SwimmerController(serviceMock.Object);

            var result = controller.Index(page);

            Assert.IsNotNull(result);
        }

        [Test]
        public void SwimmerController_Verify_Delete()
        {
            // arrange

            int id = 1;
            var serviceMock = new Mock<ISwimmerService>();

            SwimmerController controller = new SwimmerController(serviceMock.Object);
            // act
            IActionResult result = controller.Delete(id) as IActionResult;

            // assert
            serviceMock.Verify(a => a.DeleteSwimmer(id));
        }

        [Test]
        public void SwimmerController_Verify_AddingCalledOnce()
        {
            //arrange

            SwimmerDTO swimmer = new SwimmerDTO()
            {
                FirstName = "new",
                LastName = "swimmer",
                Age = 11,
                CoachId = 1
            };

            var serviceMock = new Mock<ISwimmerService>();
            serviceMock.Setup(a => a.AddSwimmer(swimmer));
            SwimmerController controller = new SwimmerController(serviceMock.Object);

            var result = controller.Create(swimmer);

            serviceMock.Verify(m => m.AddSwimmer(swimmer), Times.Once);
        }
    }
}