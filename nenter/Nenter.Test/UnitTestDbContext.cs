﻿using Dapper;
using Microsoft.Data.SqlClient;  // 用Microsoft.Data.SqlClient 替换 System.Data.SqlClient
using Nenter.Data;
using Nenter.Data.Dapper;
using Nenter.Data.Dapper.SqlAdapter;
using NUnit.Framework;

namespace Nenter.Test
{
    public class UnitTestDbContext
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var Db = new MsSqlDapperDbContext("Server=(local);Initial Catalog=master;Integrated Security=True");
            //Db.Connection.Execute("USE master; DROP DATABASE NenterTest");
            //Db.Connection.Execute($"CREATE DATABASE [NenterTest];");
            Db.Connection.Execute($"USE [NenterTest]");
           // Db.Connection.Execute(@"CREATE TABLE Addresses (Id int IDENTITY(1,1) not null, Street varchar(256) not null, CityId varchar(256) not null,  PRIMARY KEY (Id))");
           
            Db.Address.InsertAsync(new Address { Street = "Street0", CityId = "MSK" }).Wait();
            
            
            Db.Dispose();
            Assert.Pass();
        }
    }


    public class MsSqlDapperDbContext : DapperDbContext
    {
        private IDataRepository<Address> _address;

        public MsSqlDapperDbContext(string connectionString) : base(new SqlConnection(connectionString))
        {
        }

        public IDataRepository<Address> Address =>
            _address ??= new DataRepository<Address>(Connection, new SqlAdapterConfig()
            {
                SqlProvider = SqlProvider.SQLSERVER,
                UseQuotationMarks = true
            });

    }
}