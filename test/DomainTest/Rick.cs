using Bogus;
using Repository;
using System;
using Xunit;
using Xunit.Abstractions;

namespace DomainTest
{
    public class RickTest
    {
        private readonly ITestOutputHelper _output;

        public RickTest(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Construtor sendo executado");
        }


        [Fact(DisplayName = "Teste")]
        public void Should()
        {
            var faker = new Faker();

            string name = faker.Random.Word();
            var date = faker.Date.Random;

            var rick = new RickEntity();

            rick.Name = name;

            Assert.Equal(name, rick.Name);
        }

        public void Dispose()
        {
            _output.WriteLine("Dispose sendo executado");
        }
    }
}
