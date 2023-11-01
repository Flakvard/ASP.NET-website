using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcmeCorporationLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddSubmissionOver18String : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsOver18",
                table: "Submission",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: "f8235195-1f73-4bc4-8ac9-ad4b679041c4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: "1ff5a093-6e1d-4421-954a-a86c18c300f7");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: "09a4095b-09ea-4424-b771-5aff833359ce");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: "5a0b73a6-42cd-4252-a6ec-5dd6fb10430e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: "185ae65a-e0c6-4697-896c-ba9709306c99");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: "64a134c5-d36e-4dd8-928b-c639d89f001c");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: "36390dac-3a83-481d-afcc-a98e8d25545e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: "316dc451-04da-45e8-9169-1d34ac5b42ce");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: "4a95accf-676f-4a92-ae03-2cf7132f5ba4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: "6394efc9-0683-4b00-add5-578f8d554fa4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: "b2408f99-f790-4a77-90f5-755028c7ed5a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: "63fa6930-207e-4c7d-b62c-480b8cd6755a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: "73637f22-c33e-4bc4-ad9d-1a658391075d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: "57bf3363-7389-46c2-83f0-9683b19a43f8");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: "e0e2377e-313b-4130-bffe-5bc2f7185fcf");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: "1776d010-0069-47e7-a484-9943b052aa51");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: "23eedc0d-6bc5-4b2e-9426-5ffe876b0aec");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: "604d1bab-6e9f-4ab0-b32c-389daaca292d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: "9c4822ff-4fc3-4131-82b0-941fcb0e19ef");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: "a509d161-23f9-4afc-a2b7-77c2eb91312c");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: "94a2fa17-5ddc-40d0-bc2d-976646ed76ff");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: "258e3a71-8c98-41dd-b5f2-8307a3127ed2");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: "a51a336a-6dcf-49f4-881b-3d687fad00b6");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: "38947803-20be-40ae-8464-8a408f3d2487");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: "56c8e63f-bed0-4556-89e1-d00509ebd2b9");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: "e5964986-9399-43f8-8016-e5394f320a8e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: "a8c249c2-ff96-4b9f-8262-e3220e2e7ebc");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: "fef0fdd1-b974-4970-9847-57e9adc75fec");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "Guid",
                value: "40a88009-7817-4e27-b8ee-3415ae98ac28");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "Guid",
                value: "dcde552b-ecb3-40f4-8ea4-c3560115cee9");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 31,
                column: "Guid",
                value: "6280995a-98c2-4bdc-a201-7f9e7cabfee8");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "Guid",
                value: "0454d39c-d09f-4866-b512-057685abc72b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "Guid",
                value: "6e87777e-f21b-4b70-8fa9-6737f2d7ab6e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "Guid",
                value: "21d9dbbf-4748-43d0-991f-6a22e1015207");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "Guid",
                value: "893c357e-16d6-421d-821e-fd75589bff08");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "Guid",
                value: "29db9e90-161b-4bdd-8beb-8a9b7eef2f2e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "Guid",
                value: "2f3289ba-f152-4342-aa76-4745c18b47e6");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "Guid",
                value: "e0e27414-7512-4c30-84f5-172e89d856c8");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "Guid",
                value: "780eac06-5e0a-4e18-a03f-13c03252ff2e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "Guid",
                value: "27a06b15-437e-48ae-82e5-6d87b5c1c612");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "Guid",
                value: "60a83e91-c971-4513-914c-d44855b50a63");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "Guid",
                value: "c788845d-f81f-42fb-892e-c8f7e05ccd3f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "Guid",
                value: "00288e22-548e-4804-8b2e-3ab9201f4265");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "Guid",
                value: "16645ed1-133f-4f93-b3e6-9a5550c7ed0e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "Guid",
                value: "18644266-b66a-4675-9454-eeaba81726ff");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "Guid",
                value: "f6e81eda-42eb-4b7d-b248-3a8f6ecc9b30");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "Guid",
                value: "64fbfdfb-f0da-4dbc-801d-9ff611f57bc2");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "Guid",
                value: "87a46c4d-59b0-4498-9123-b824b7cef05b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "Guid",
                value: "7dccbd78-bb85-468c-a97c-ea97b24256cc");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "Guid",
                value: "6df17efc-66b1-40e0-9e44-1b9ebf09a171");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 51,
                column: "Guid",
                value: "fe49855b-44ab-4ad5-95c3-68ab8a0e56a4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 52,
                column: "Guid",
                value: "a1910ce4-a9e5-4ef2-8921-7186f7d5f92e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 53,
                column: "Guid",
                value: "514a072d-8f0b-4e00-b634-fc203bd1899c");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 54,
                column: "Guid",
                value: "9a48ede5-b888-4168-9ca0-6f12cc7e2666");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 55,
                column: "Guid",
                value: "5bfe1bf0-7743-472d-ab9f-62c8145efdef");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 56,
                column: "Guid",
                value: "92d5291f-4e41-4550-896f-d6d11d332b52");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 57,
                column: "Guid",
                value: "e4c7a83f-57c0-4bfa-98e0-9c708d202ce9");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 58,
                column: "Guid",
                value: "589b5493-8eba-40c5-8fbe-7349400b3b51");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 59,
                column: "Guid",
                value: "17a14a78-00f1-47ef-9011-6a9bb72cf90f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 60,
                column: "Guid",
                value: "20505bb2-23f3-48c5-a323-887d7951020c");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 61,
                column: "Guid",
                value: "ce387555-432b-4374-ba9f-4a86d1feace6");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 62,
                column: "Guid",
                value: "037f37f0-37eb-4300-8239-ed53e715f847");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 63,
                column: "Guid",
                value: "383f1f46-5bf3-4479-a25d-3b23af1b9036");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 64,
                column: "Guid",
                value: "90169bd9-57bd-4480-a770-b3fbd7b67888");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 65,
                column: "Guid",
                value: "8f9d5095-30f6-4813-b7f6-598bf6799ce8");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 66,
                column: "Guid",
                value: "5f49cf0b-1020-4e02-b7fa-12f86732bcc4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 67,
                column: "Guid",
                value: "4693cb9b-9bff-4fd1-a51a-a46c6146cc50");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 68,
                column: "Guid",
                value: "f7b8860a-5ed6-4afe-8d2f-30c15960350a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 69,
                column: "Guid",
                value: "47cf40f0-676b-4a6f-8719-da8834208043");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 70,
                column: "Guid",
                value: "b53438d5-4a43-4b71-a201-e9fadd138384");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 71,
                column: "Guid",
                value: "26ca4bef-aa8d-4db5-adf3-9ae6b72e71e2");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 72,
                column: "Guid",
                value: "c3905fd5-15e9-4056-96bb-4ae47edf2b40");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 73,
                column: "Guid",
                value: "48b60f5d-18af-466b-a954-bfaa14f05bff");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 74,
                column: "Guid",
                value: "9e9f9397-e65e-48d2-8e7d-f985e06f8dcf");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 75,
                column: "Guid",
                value: "c9cd0f77-0027-432d-855a-fd01f86706f4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 76,
                column: "Guid",
                value: "b6093bd2-bbc5-4cf4-9e97-7dad863072bc");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 77,
                column: "Guid",
                value: "54cd59ec-5088-40a5-8112-83cb536b5492");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 78,
                column: "Guid",
                value: "0bff9568-074a-41a9-bcee-f8d5a465fa7a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 79,
                column: "Guid",
                value: "848af053-b485-4cea-8ece-b828391c1a40");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 80,
                column: "Guid",
                value: "25f05495-e519-40b1-be2d-ff01cc19472a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 81,
                column: "Guid",
                value: "2570568e-0805-46d7-9263-8110a92140a1");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 82,
                column: "Guid",
                value: "c3ef4d0d-dbf5-4275-93d1-5c930524058b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 83,
                column: "Guid",
                value: "82b7b3cf-d97d-4102-9e09-9ce9654993e8");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 84,
                column: "Guid",
                value: "6fbed212-8ee1-450a-bba2-0851dc3b0eed");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 85,
                column: "Guid",
                value: "aa3063ce-bf19-4c2d-8fe6-7bb1ccbd24c4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 86,
                column: "Guid",
                value: "1d3cf1e0-8695-452c-b62b-2438dd4416aa");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 87,
                column: "Guid",
                value: "890ef138-6be0-4213-a31d-8aa7ea5f6fb9");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 88,
                column: "Guid",
                value: "0aa5107a-6251-467e-aeff-6b2603bebff8");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 89,
                column: "Guid",
                value: "4e907d77-cfb0-4280-9c72-77a59f9b4f35");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 90,
                column: "Guid",
                value: "0df49356-ed71-4e77-b0d1-f317dbcec62f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 91,
                column: "Guid",
                value: "402cf86d-9462-4385-b63e-5efcfdb5ae32");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 92,
                column: "Guid",
                value: "8a76ac15-1a3d-495a-a9dc-98034ac5dc84");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 93,
                column: "Guid",
                value: "56461c23-0cbc-4740-965d-001b7e7419b1");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 94,
                column: "Guid",
                value: "251ec7c5-0538-4dbb-b4c6-25949898af22");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 95,
                column: "Guid",
                value: "b4bf29d1-e79e-468d-8aab-4172e06b5782");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 96,
                column: "Guid",
                value: "807c585e-4d2a-4011-a93d-53e6ac468cfe");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 97,
                column: "Guid",
                value: "c581c845-85eb-49eb-ad59-7e8f8ce72f0f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 98,
                column: "Guid",
                value: "25aa361f-563a-434c-b103-7c1969abab7c");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 99,
                column: "Guid",
                value: "ec4671a0-824b-45fb-b28f-06d8312a1750");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 100,
                column: "Guid",
                value: "a8ae828d-82de-417d-a228-bce8bc66bef5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsOver18",
                table: "Submission",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guid",
                value: "681ca54e-2184-441a-9d2a-92ed7426bc35");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guid",
                value: "731b1ec0-cd5b-46db-9da2-b3324f3e1e1b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Guid",
                value: "b8aa8726-90f7-4772-bcb4-56e25738447e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Guid",
                value: "1d7c6296-e8d5-4e73-aa92-446a6b0505d0");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Guid",
                value: "fa015e4d-4008-422a-8064-05d2ad3953ff");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Guid",
                value: "668bf062-31f2-49d7-9e42-e7a3e0bbb3c0");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Guid",
                value: "5dddee3d-929d-474c-ae71-1505850f2b26");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 8,
                column: "Guid",
                value: "5cc07891-e60e-4fc7-8431-f72fd18e3eef");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 9,
                column: "Guid",
                value: "7b78b80e-b8b7-4491-a81f-55b2afd382bf");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 10,
                column: "Guid",
                value: "30506ac0-f0cb-4eb8-9fa1-f77dc7dff987");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Guid",
                value: "317300a1-b319-41f7-b8b6-06c52f4ca1c4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Guid",
                value: "01621e8c-7fcf-41bd-9b6b-d1126d3aef6e");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 13,
                column: "Guid",
                value: "884302fa-4912-46ca-9b11-839fa5670e2d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 14,
                column: "Guid",
                value: "359542c5-1b9c-4d90-9299-f5dcc7d92803");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 15,
                column: "Guid",
                value: "7027feba-4c44-4a4e-895f-d5c846d1398f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 16,
                column: "Guid",
                value: "1992a924-fda1-4ee5-9808-f9ad9fae940b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 17,
                column: "Guid",
                value: "3d5c6b66-9094-4242-b9d3-87245f097a1d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 18,
                column: "Guid",
                value: "b0348df5-2615-4ca0-8812-df15473dfc25");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 19,
                column: "Guid",
                value: "6d1154e6-ef7d-45b3-9187-aa824b780bf2");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 20,
                column: "Guid",
                value: "21a4774f-321c-4edf-9a96-1d342bfd7a08");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 21,
                column: "Guid",
                value: "f6b8b362-cf49-406f-981d-237755b0fd69");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 22,
                column: "Guid",
                value: "16b95745-c762-4611-838e-e90aba28673f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 23,
                column: "Guid",
                value: "11610fbd-deb2-4c51-84d2-a1f322ba67a0");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 24,
                column: "Guid",
                value: "42d763a6-8577-4bd4-bd4a-a1b4594f8130");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 25,
                column: "Guid",
                value: "4bccc3ed-d3bd-49b7-88b3-4c17634cc4a3");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 26,
                column: "Guid",
                value: "4b786cbc-79a5-4057-8db3-d5251f9cd9b2");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 27,
                column: "Guid",
                value: "6001229c-e85d-45aa-a691-956698b61b50");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 28,
                column: "Guid",
                value: "7e386580-07c8-4cf4-93fa-5ecf63435022");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 29,
                column: "Guid",
                value: "7db8ae45-25f7-4561-9ea0-fd5039f5b7d5");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 30,
                column: "Guid",
                value: "4e2caec9-388c-4728-88b5-201d6ab66a1f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 31,
                column: "Guid",
                value: "e8206532-254f-4046-b4b6-10bb97ea6a68");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 32,
                column: "Guid",
                value: "7f6ea2ee-0b55-4bc6-bd50-430a8e6ad844");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 33,
                column: "Guid",
                value: "42b14970-b273-41a8-90ec-d31f59daa869");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 34,
                column: "Guid",
                value: "31c79c30-1780-4391-a77f-cc0d744f214d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 35,
                column: "Guid",
                value: "2ce86e4e-b96e-4284-b109-638cd9dbe1dc");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 36,
                column: "Guid",
                value: "9de488e9-d7f6-4fc0-a6f6-5d3a4430f6b3");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 37,
                column: "Guid",
                value: "2bfaaf88-1f66-4c4c-a32f-ddc262a11431");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 38,
                column: "Guid",
                value: "90c01119-3499-4633-a32f-0afbcc3ea32b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 39,
                column: "Guid",
                value: "a41bf1d9-4a60-4451-a99b-2db09382a980");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 40,
                column: "Guid",
                value: "cfedf8de-ec49-423c-af5d-64163fd82470");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 41,
                column: "Guid",
                value: "475f1585-b195-4038-94ae-7ba54f6c3955");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 42,
                column: "Guid",
                value: "ff7625be-ce20-43eb-8b88-a0ab53a43754");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 43,
                column: "Guid",
                value: "176cb7bf-f5db-42d6-b8f0-83db6700910f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 44,
                column: "Guid",
                value: "734136be-d007-4a78-a683-93e4d66b3ade");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 45,
                column: "Guid",
                value: "ecc24f40-2aa8-4ab6-9d1d-572cdd1e1d69");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 46,
                column: "Guid",
                value: "f9ab15d9-bfa6-408f-9bb1-aa8ffd55a163");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 47,
                column: "Guid",
                value: "a6a0b9f7-e451-445e-8cad-6dee82583c1b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 48,
                column: "Guid",
                value: "35940faa-1c5b-4416-b1b8-f0f3da02d517");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 49,
                column: "Guid",
                value: "1f6cde58-bdf7-4e9b-82e9-0910a3fc2695");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 50,
                column: "Guid",
                value: "79a2b215-b119-45dc-ae02-4b9e37d46e4b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 51,
                column: "Guid",
                value: "0ce1ca0b-8c44-42fa-9543-2fe1ef8d9722");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 52,
                column: "Guid",
                value: "12a05b95-b342-4612-8409-d693a4b8a6d5");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 53,
                column: "Guid",
                value: "13333f1a-6fa9-4b16-b276-d59aa7c10374");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 54,
                column: "Guid",
                value: "94e90d31-1ea5-4c7b-9db4-9af8c41ca25d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 55,
                column: "Guid",
                value: "8e0a51f6-2663-4201-ac7c-cb7987b90c6a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 56,
                column: "Guid",
                value: "1de6b03e-b15e-414e-8e0c-4083570f32a6");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 57,
                column: "Guid",
                value: "6bc8eca7-e2df-4f4a-b12b-2128fc11e345");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 58,
                column: "Guid",
                value: "34d95f57-3f0e-4cb8-b82e-67135a787362");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 59,
                column: "Guid",
                value: "f106f536-e114-46a7-b933-625e75b7b811");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 60,
                column: "Guid",
                value: "68362832-04f8-4556-815b-f60c4d867d85");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 61,
                column: "Guid",
                value: "a07e4247-ab46-46e8-a29c-7e34ae36e4db");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 62,
                column: "Guid",
                value: "f660ccac-1df9-4e07-bfd9-d92394bed66d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 63,
                column: "Guid",
                value: "e821d130-aa11-47a6-984a-0f3d3e054b23");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 64,
                column: "Guid",
                value: "df07e3d5-94a6-4c00-bbf8-de0c0f623286");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 65,
                column: "Guid",
                value: "1ab29163-5589-470b-8b22-08c16c4dc77b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 66,
                column: "Guid",
                value: "ea08c54e-b3f0-4a98-9be3-d5cf332f4d99");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 67,
                column: "Guid",
                value: "82ceade0-0ac2-4d42-815a-e50f70c99ebb");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 68,
                column: "Guid",
                value: "698c2af6-42fa-4906-9204-2f347ae08ff7");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 69,
                column: "Guid",
                value: "018318c1-f6bb-48c1-acde-55f3acc2e108");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 70,
                column: "Guid",
                value: "669e3ccc-d92b-40fe-a8c6-920b33de7f19");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 71,
                column: "Guid",
                value: "3cd351f1-7a0a-4f08-b5d1-0159016cf360");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 72,
                column: "Guid",
                value: "6be18039-a864-46ca-9e11-02e4d1985abe");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 73,
                column: "Guid",
                value: "eadcda16-ac7e-474f-abe4-2366850c97e5");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 74,
                column: "Guid",
                value: "53a79397-561e-453e-aa4c-19305834b754");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 75,
                column: "Guid",
                value: "2432b8c7-3c7d-4e5b-80f9-12bccafb9266");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 76,
                column: "Guid",
                value: "0738adc7-9fff-40a5-a231-5329ad08ad65");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 77,
                column: "Guid",
                value: "1fa5fb71-069f-4086-87c0-0118263ee482");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 78,
                column: "Guid",
                value: "af2e4061-b59d-411d-86d1-29458ef146fd");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 79,
                column: "Guid",
                value: "f6e72248-7cce-4370-8d7c-71ad733708de");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 80,
                column: "Guid",
                value: "87ff47d0-0141-4ece-b0e4-0523bdf52f4b");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 81,
                column: "Guid",
                value: "7288f0bb-f28a-4369-b2a6-d549a629ad2a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 82,
                column: "Guid",
                value: "e006f007-5fa0-4696-b019-129c6ebe1bd6");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 83,
                column: "Guid",
                value: "48c75674-efba-432f-bfae-1d1db07b3627");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 84,
                column: "Guid",
                value: "5efc14a9-ce59-4821-9036-2b5802bf4ac2");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 85,
                column: "Guid",
                value: "c30fc5c1-f54b-46d9-8759-18542a29e8b4");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 86,
                column: "Guid",
                value: "56b7edf3-dec8-4e75-9779-b20bad38ca81");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 87,
                column: "Guid",
                value: "d23c7574-818c-4d10-8b87-1bc2212c41bb");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 88,
                column: "Guid",
                value: "ab76d76f-e218-4bbe-a44f-2a093e65af2a");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 89,
                column: "Guid",
                value: "e4593067-60f9-412e-94d1-673a25826f3f");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 90,
                column: "Guid",
                value: "19a2d5d8-755c-4d6e-881e-e20b8e7eba36");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 91,
                column: "Guid",
                value: "00b5d2ad-af7b-4073-aff3-47305d2011f3");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 92,
                column: "Guid",
                value: "7c536f87-1b49-46ac-83d8-740a896bc6ca");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 93,
                column: "Guid",
                value: "3431f3fe-7b57-40d8-8ba6-9e6d24369b24");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 94,
                column: "Guid",
                value: "72932df0-5b52-44ad-96d3-f4c6e6f5d563");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 95,
                column: "Guid",
                value: "f1a59fdc-7b39-4341-a6b7-6d79ae128642");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 96,
                column: "Guid",
                value: "725671bb-33d3-4d08-938a-f283e5ffca43");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 97,
                column: "Guid",
                value: "b50bbfa4-dc4c-4664-80e8-b2b91f9f79ba");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 98,
                column: "Guid",
                value: "8371a823-4a85-41e6-97fe-44223d655f7d");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 99,
                column: "Guid",
                value: "f53e128d-4031-400e-b86e-64346f9f2f84");

            migrationBuilder.UpdateData(
                table: "SerialNumbers",
                keyColumn: "Id",
                keyValue: 100,
                column: "Guid",
                value: "afb6b3ca-48b2-4ea7-8233-d88b8387f848");
        }
    }
}
