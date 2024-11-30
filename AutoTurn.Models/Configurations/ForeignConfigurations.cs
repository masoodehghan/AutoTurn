using AutoTurn.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.IO;
using System.Numerics;

namespace AutoTurn.Models.Configurations;

public class ForeignConfigurations : IEntityTypeConfiguration<Foreign>
{
    private const int N = 100;
    private List<Foreign> _seedForeigns = new();
    private List<Address> _seedAddress = new();
    public void Configure(EntityTypeBuilder<Foreign> builder)
    {
        //GenerateAddress();

        //SeedModel(builder);
        //builder.HasData(_seedForeigns);

        builder.OwnsOne(f => f.Address);//.HasData(_seedAddress);
        builder.HasIndex(f => f.PassportCode).IsUnique();
        builder.Property(f => f.PassportCode).HasMaxLength(9);
        builder.HasIndex(f => f.YektaCode).IsUnique();
        builder.HasIndex(f => f.FaragirCode).IsUnique();
        builder.HasIndex(f => f.SpecificCode).IsUnique();
        
    }

    private void SeedModel(EntityTypeBuilder<Foreign> builder)
    {
        Random rand = new Random();

        string chars = "qwertyuiopasdfghjklzxcvbnm123456789";
        
        string[] names = new[]
        {
            "foor",
            "bar",
            "test",
            "ali",
            "mahdi"
        };
        Address adress = _seedAddress[rand.Next(N)];
        for (int i = 1; i < N; i++)
        {
            
            var foreign = new Foreign
            {
                
                Id = i,
                FirstName = names[rand.Next(names.Length)],
                LastName = names[rand.Next(names.Length)],
                FaragirCode = rand.NextInt64(
                    100_000_000_000_00,
                    100_000_000_000_000_00),
                YektaCode = rand.NextInt64(900_000_000_0, 100_000_000_00),
                SpecificCode = rand.NextInt64(100_000_000_000, 100_000_000_000_0),
                PassportCode = new string(Enumerable.Repeat(chars, 9)
                        .Select(s => s[rand.Next(s.Length)]).ToArray()),
                
                MobileNumber = GenerateNumber(),
                
                
            };
            _seedForeigns.Add(foreign);
        }

        
    }

    private string GenerateNumber()
    {
        string numbers = "0123456789";

        Random random = new Random();

        string phoneNumber = "+98";

        for (int i = 0; i < 10; i++)
        {
            phoneNumber += numbers[random.Next(numbers.Length)];
        }

        return phoneNumber;
    }

    private void GenerateAddress()
    {
        string[] Provinces = ["yazd", "tehran"];
        string[] city = ["yazd", "tehran"];
        string[] street = ["test", "sha"];
        string[] postalCode = ["123df", "12345fg"];
        Random rand = new Random();
        for (int i = 1; i < N; i++) {
            Address adress = new Address
            {
                Province = Provinces[rand.Next(2)],
                City = city[rand.Next(city.Length)],
                Street = street[rand.Next(street.Length)],
                PostalCode = postalCode[rand.Next(postalCode.Length)],
                ForeignId = i
            };

            _seedAddress.Add(adress);
        }

    }
}
