﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unicab.Api.Contexts;

namespace Unicab.Api.Migrations
{
    [DbContext(typeof(UnicabContext))]
    partial class UnicabContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Unicab.Api.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("CurrentLoginDateTime");

                    b.Property<string>("CurrentLoginUniqueId");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsLoggedIn");

                    b.Property<DateTime>("LastLoginDateTime");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<string>("Notes");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<byte[]>("ProfilePhoto");

                    b.Property<string>("StaffNo");

                    b.Property<string>("StaffPosition");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Unicab.Api.Models.CabRequest", b =>
                {
                    b.Property<int>("CabRequestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("AdditionalNotes");

                    b.Property<int?>("DropOffLocationLocationId");

                    b.Property<bool>("IsAccepted");

                    b.Property<bool>("IsLadiesOnly");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<int>("NoOfPassengers");

                    b.Property<int>("PassengerId");

                    b.Property<DateTime>("PickUpDateTime");

                    b.Property<int?>("PickUpLocationLocationId");

                    b.Property<int>("RequestPeriod");

                    b.HasKey("CabRequestId");

                    b.HasIndex("DropOffLocationLocationId");

                    b.HasIndex("PassengerId");

                    b.HasIndex("PickUpLocationLocationId");

                    b.ToTable("CabRequests");
                });

            modelBuilder.Entity("Unicab.Api.Models.CabRequestFulfillment", b =>
                {
                    b.Property<int>("CabRequestFulfillmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CabRequestId");

                    b.Property<double>("DistanceTravelled");

                    b.Property<DateTime>("DriverCompletedDateTime");

                    b.Property<bool>("DriverHasCompleted");

                    b.Property<int>("DriverId");

                    b.Property<double>("FareCharge");

                    b.Property<bool>("IsFarePaid");

                    b.Property<DateTime>("PassengerCompletedDateTime");

                    b.Property<bool>("PassengerHasCompleted");

                    b.HasKey("CabRequestFulfillmentId");

                    b.HasIndex("CabRequestId");

                    b.HasIndex("DriverId");

                    b.ToTable("CabRequestFulfillments");
                });

            modelBuilder.Entity("Unicab.Api.Models.CarpoolOffer", b =>
                {
                    b.Property<int>("CarpoolOfferId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("AdditionalNotes");

                    b.Property<int?>("DestinationLocationLocationId");

                    b.Property<int>("DriverId");

                    b.Property<bool>("IsAccepted");

                    b.Property<bool>("IsLadiesOnly");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<int>("NoOfPassengers");

                    b.Property<int>("OfferPeriod");

                    b.Property<DateTime>("OriginDateTime");

                    b.Property<int?>("OriginLocationLocationId");

                    b.HasKey("CarpoolOfferId");

                    b.HasIndex("DestinationLocationLocationId");

                    b.HasIndex("DriverId");

                    b.HasIndex("OriginLocationLocationId");

                    b.ToTable("CarpoolOffers");
                });

            modelBuilder.Entity("Unicab.Api.Models.CarpoolOfferFulfillment", b =>
                {
                    b.Property<int>("CarpoolOfferFulfillmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarpoolOfferId");

                    b.Property<double>("DistanceTravelled");

                    b.Property<DateTime>("DriverCompletedDateTime");

                    b.Property<bool>("DriverHasCompleted");

                    b.Property<double>("FareCharge");

                    b.Property<bool>("IsFarePaid");

                    b.Property<bool>("IsFareSplit");

                    b.Property<DateTime>("PassengerCompletedDateTime");

                    b.Property<bool>("PassengerHasCompleted");

                    b.Property<int>("PassengerId");

                    b.HasKey("CarpoolOfferFulfillmentId");

                    b.HasIndex("CarpoolOfferId");

                    b.HasIndex("PassengerId");

                    b.ToTable("CarpoolOfferFulfillments");
                });

            modelBuilder.Entity("Unicab.Api.Models.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedByAdminId");

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("CarColour");

                    b.Property<byte[]>("CarInsuranceGrantPhoto");

                    b.Property<string>("CarMake");

                    b.Property<string>("CarMakeYear");

                    b.Property<string>("CarModel");

                    b.Property<string>("CarPlateNo");

                    b.Property<DateTime>("CarRoadTaxDueDate");

                    b.Property<DateTime>("CurrentLoginDateTime");

                    b.Property<string>("CurrentLoginUniqueId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DriversLicenseDueDate");

                    b.Property<byte[]>("DriversLicensePhoto");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsLoggedIn");

                    b.Property<DateTime>("LastLoginDateTime");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("MatricsCardPhoto");

                    b.Property<string>("MatricsNo");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<string>("Notes");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<byte[]>("ProfilePhoto");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Unicab.Api.Models.DriverApplicant", b =>
                {
                    b.Property<int>("DriverApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ApprovedByAdminId");

                    b.Property<DateTime>("ApprovedDateTime");

                    b.Property<string>("CarColour");

                    b.Property<byte[]>("CarInsuranceGrantPhoto");

                    b.Property<string>("CarMake");

                    b.Property<string>("CarMakeYear");

                    b.Property<string>("CarModel");

                    b.Property<string>("CarPlateNo");

                    b.Property<DateTime>("CarRoadTaxDueDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DriversLicenseDueDate");

                    b.Property<byte[]>("DriversLicensePhoto");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<bool>("IsApproved");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("MatricsCardPhoto");

                    b.Property<string>("MatricsNo");

                    b.Property<string>("Notes");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("DriverApplicantId");

                    b.ToTable("DriverApplicants");
                });

            modelBuilder.Entity("Unicab.Api.Models.DriverBlacklist", b =>
                {
                    b.Property<int>("DriverBlacklistId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlacklistedByAdminId");

                    b.Property<DateTime>("BlacklistedDateTime");

                    b.Property<int>("BlacklistedDuration");

                    b.Property<string>("BlacklistedReason");

                    b.Property<int>("DriverId");

                    b.Property<int>("UnblacklistedByAdminId");

                    b.Property<DateTime>("UnblacklistedDateTime");

                    b.Property<string>("UnblacklistedReason");

                    b.HasKey("DriverBlacklistId");

                    b.ToTable("DriverBlacklists");
                });

            modelBuilder.Entity("Unicab.Api.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsWithinUSM");

                    b.Property<double>("LocationLatitude");

                    b.Property<double>("LocationLongitude");

                    b.Property<string>("LocationName");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Unicab.Api.Models.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedByAdminId");

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("CurrentLoginDateTime");

                    b.Property<string>("CurrentLoginUniqueId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsLoggedIn");

                    b.Property<DateTime>("LastLoginDateTime");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("MatricsCardPhoto");

                    b.Property<string>("MatricsNo");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<string>("Notes");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<byte[]>("ProfilePhoto");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("Unicab.Api.Models.PassengerApplicant", b =>
                {
                    b.Property<int>("PassengerApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ApprovedByAdminId");

                    b.Property<DateTime>("ApprovedDateTime");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<bool>("IsApproved");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("MatricsCardPhoto");

                    b.Property<string>("MatricsNo");

                    b.Property<string>("Notes");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("PassengerApplicantId");

                    b.ToTable("PassengerApplicants");
                });

            modelBuilder.Entity("Unicab.Api.Models.PassengerBlacklist", b =>
                {
                    b.Property<int>("PassengerBlacklistId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlacklistedByAdminId");

                    b.Property<DateTime>("BlacklistedDateTime");

                    b.Property<int>("BlacklistedDuration");

                    b.Property<string>("BlacklistedReason");

                    b.Property<int>("PassengerId");

                    b.Property<int>("UnblacklistedByAdminId");

                    b.Property<DateTime>("UnblacklistedDateTime");

                    b.Property<string>("UnblacklistedReason");

                    b.HasKey("PassengerBlacklistId");

                    b.ToTable("PassengerBlacklists");
                });

            modelBuilder.Entity("Unicab.Api.Models.RatingFeedback", b =>
                {
                    b.Property<int>("RatingFeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeedbackCabRequestId");

                    b.Property<int>("FeedbackCarpoolId");

                    b.Property<string>("FeedbackText");

                    b.Property<bool>("IsCabRequestFeedback");

                    b.Property<bool>("IsCarpoolFeedback");

                    b.Property<bool>("IsDriverFeedback");

                    b.Property<bool>("IsPassengerFeedback");

                    b.Property<double>("RatingScore");

                    b.Property<DateTime>("SentByDriverDateTime");

                    b.Property<int>("SentByDriverId");

                    b.Property<DateTime>("SentByPassengerDateTime");

                    b.Property<int>("SentByPassengerId");

                    b.Property<int>("SentToDriverId");

                    b.Property<int>("SentToPassengerId");

                    b.HasKey("RatingFeedbackId");

                    b.ToTable("RatingFeedbacks");
                });

            modelBuilder.Entity("Unicab.Api.Models.CabRequest", b =>
                {
                    b.HasOne("Unicab.Api.Models.Location", "DropOffLocation")
                        .WithMany()
                        .HasForeignKey("DropOffLocationLocationId");

                    b.HasOne("Unicab.Api.Models.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Unicab.Api.Models.Location", "PickUpLocation")
                        .WithMany()
                        .HasForeignKey("PickUpLocationLocationId");
                });

            modelBuilder.Entity("Unicab.Api.Models.CabRequestFulfillment", b =>
                {
                    b.HasOne("Unicab.Api.Models.CabRequest", "CabRequest")
                        .WithMany()
                        .HasForeignKey("CabRequestId");

                    b.HasOne("Unicab.Api.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Unicab.Api.Models.CarpoolOffer", b =>
                {
                    b.HasOne("Unicab.Api.Models.Location", "DestinationLocation")
                        .WithMany()
                        .HasForeignKey("DestinationLocationLocationId");

                    b.HasOne("Unicab.Api.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Unicab.Api.Models.Location", "OriginLocation")
                        .WithMany()
                        .HasForeignKey("OriginLocationLocationId");
                });

            modelBuilder.Entity("Unicab.Api.Models.CarpoolOfferFulfillment", b =>
                {
                    b.HasOne("Unicab.Api.Models.CarpoolOffer", "CarpoolOffer")
                        .WithMany()
                        .HasForeignKey("CarpoolOfferId");

                    b.HasOne("Unicab.Api.Models.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
