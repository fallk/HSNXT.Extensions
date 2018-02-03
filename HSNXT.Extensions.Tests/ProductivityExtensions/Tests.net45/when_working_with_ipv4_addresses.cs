﻿#if false
using System.Net;
using NUnit.Framework;
using HSNXT;
using HSNXT;

namespace Tests.net45
{
	[TestFixture]
	public class when_working_with_ipv4_addresses
	{
		[Test]
		public void then_loopback_should_not_be_link_local()
		{
			IPAddress ipaddress = IPAddress.Loopback;
			Assert.IsFalse(ipaddress.IsIPv4LinkLocal());
		}

		[Test]
		public void then_link_local_should_be_link_local()
		{
			IPAddress ipaddress = IPAddress.Parse("169.254.0.1");
			Assert.IsTrue(ipaddress.IsIPv4LinkLocal());
		}

		[Test]
		public void then_null_argument_throws()
		{
			IPAddress ipaddress = null;
			// ReSharper disable once ExpressionIsAlwaysNull
			Assert.Throws<System.ArgumentNullException>(()=>ipaddress.IsIPv4LinkLocal());
		}
	}
}
#endif