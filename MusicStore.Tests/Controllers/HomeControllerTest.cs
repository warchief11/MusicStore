using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MusicStore.Controllers;
using MusicStore.Tests.MockData;
using MusicStore.ViewModels;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicStore.Tests.Controllers
{
    /// <summary>
    /// Summary description for HomeControllerTest
    /// </summary>
    [TestClass]
    public class HomeControllerTest
    {
        public HomeControllerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public async Task HomePageReturnsValidViewModel()
        {
            //arrange
            var fakeDB = new FakeMusicStoreContext();
            fakeDB.AddSet(MusicStoreTestData.Albums);
            fakeDB.AddSet(MusicStoreTestData.Artists);
            fakeDB.AddSet(MusicStoreTestData.Genres);

            var context = new Mock<HttpContextBase>();
            var session = new Mock<HttpSessionStateBase>();
            context.Setup(x => x.Session).Returns(session.Object);
            var requestContext = new RequestContext(context.Object, new RouteData());
            var controller = new HomeController(fakeDB);
            controller.ControllerContext = new ControllerContext(requestContext, controller);
            //act
            var result = (await controller.Index()) as ViewResult;
            var viewModel = result.Model as HomePageViewModel;

            //assert
            Assert.IsNotNull(viewModel.FeaturedArtist);
            Assert.IsNotNull(viewModel.FeaturedAlbums);
            Assert.AreEqual(viewModel.TopSellingAlbums.Count, 10);
        }
    }
}