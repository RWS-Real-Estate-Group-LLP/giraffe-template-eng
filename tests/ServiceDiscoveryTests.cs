// Unit Tests for Service Discovery functionality.

using NUnit.Framework;

using ServiceDiscovery;



namespace ServiceDiscoveryTests

{

    [TestFixture]

    public class ServiceDiscoveryTests

    {

        private ServiceDiscovery _serviceDiscovery;



        [SetUp]

        public void SetUp()

        {

            _serviceDiscovery = new ServiceDiscovery("http://localhost:5000/services");

        }



        [Test]

        public async Task TestDiscoverServicesAsync()

        {

            var services = await _serviceDiscovery.DiscoverServicesAsync();

            Assert.IsNotNull(services);

|         Assert.IsTrue(services.Count > 0);
\         }}
