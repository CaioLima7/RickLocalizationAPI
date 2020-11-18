using Bogus;
using Repository;
using System;
using Xunit;
using Xunit.Abstractions;

namespace DomainTest
{
    public class OperationsTest : IDisposable
    {
        private readonly ITestOutputHelper _output;

        public OperationsTest(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Construtor sendo executado.");
        }


        [Fact(DisplayName = "RegistrarNavegacao")]
        public void DeveRegistrarNovaNavegacao()
        {
            var faker = new Faker();
            string nome = faker.Random.Word();
            //Teste viagem futura
            var data = faker.Date.Future(50);

            var navigation = new NavigationEntity();

            navigation.TravelName = nome;
            navigation.Date = data;

            Assert.Equal(nome, navigation.TravelName);
            Assert.Equal(data, navigation.Date);

            Dispose();
        }

        public void Dispose()
        {
            _output.WriteLine("Dispose sendo executado");
        }
    }
}
