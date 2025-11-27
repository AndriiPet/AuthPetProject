using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("45de91c1-e4fc-4e75-90eb-0124d566baac"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4be7f198-4bd3-4746-961f-cb316fd22666"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("67955dba-061e-4c42-8236-9cb48e89ebed"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6f5f4520-c2e6-4245-846f-f1645bc3a06a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7db30136-34c6-4251-8a9f-264674d206cd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("832a16ef-96d5-4b2c-96bf-bc65f32b9cff"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b623e5f0-262f-4a83-ae1e-846f7ac51592"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e3fce794-44ef-4f7a-9f65-c0e9633dba38"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("11e9e609-29a1-4fcb-bccd-7289c31376d0"), "df22196a-5c02-45c9-9300-a6e71020c622", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("5ea1844a-d7aa-48f5-8c6a-3b409d7a04e7"), "2db72d7e-2ee5-4bac-8a07-1ff407fe110e", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("615a3cdb-3316-4520-a52d-6d9691740822"), "2d19aef5-d350-46eb-96cf-ec86123f9718", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("748fdb83-f1f7-49dc-bd6a-f2c535da9549"), "59ba8da1-5981-4558-8056-7fbb39c0d6a3", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("8c9540bb-fc21-4625-a99c-6e2aad000426"), "9099f8e9-089a-441a-a4bc-3b39aa9b2794", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("a014f84d-054d-403c-b97f-9bfe6d893bbf"), "d89eb6af-ed67-40b2-bab2-db00d0f48e05", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("bdd447e1-d160-4394-8556-3db45e0afba2"), "c8a7d19a-0658-4fb8-807f-67f8bcb902d0", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("c85093fe-032f-46e5-a4ec-cb8acf1e3435"), "3a6ca55a-01ba-483a-b16b-4bafcc07180c", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "20d4775c-d49e-474b-a942-f7cafb9aa8c2", "david@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "ae3e8fe7-2586-43f6-bcd7-84d1a49070a7", "emma@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("11e9e609-29a1-4fcb-bccd-7289c31376d0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5ea1844a-d7aa-48f5-8c6a-3b409d7a04e7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("615a3cdb-3316-4520-a52d-6d9691740822"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("748fdb83-f1f7-49dc-bd6a-f2c535da9549"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8c9540bb-fc21-4625-a99c-6e2aad000426"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a014f84d-054d-403c-b97f-9bfe6d893bbf"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("bdd447e1-d160-4394-8556-3db45e0afba2"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c85093fe-032f-46e5-a4ec-cb8acf1e3435"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("45de91c1-e4fc-4e75-90eb-0124d566baac"), "ec6af68a-3a9a-4454-8bb8-30ed737fbf1a", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("4be7f198-4bd3-4746-961f-cb316fd22666"), "71cb86f0-544c-4b04-935f-debd83675369", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("67955dba-061e-4c42-8236-9cb48e89ebed"), "9b5cba36-3095-4b21-90c8-8fa20b412c19", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("6f5f4520-c2e6-4245-846f-f1645bc3a06a"), "9b14a46b-d4f3-496c-ba2b-6f59d8455555", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("7db30136-34c6-4251-8a9f-264674d206cd"), "3af9e238-d76e-4f27-b34e-e30df6816abe", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("832a16ef-96d5-4b2c-96bf-bc65f32b9cff"), "4c554e1b-a056-495f-ba9a-e04b26e354c9", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("b623e5f0-262f-4a83-ae1e-846f7ac51592"), "e7de9d3e-aa13-4b29-9294-7e887915b582", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("e3fce794-44ef-4f7a-9f65-c0e9633dba38"), "0e3f227a-4276-456d-9e24-a7fb20716468", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "ac7a96e5-1a77-4fd5-8c70-7b98958522dd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "af0346be-1962-4a5f-802d-b06abffa4dbc");
        }
    }
}
