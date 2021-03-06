﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace AbstractFactory
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Client
	{
		private AbstractProduct_A Product1
		{
			get;
			set;
		}

		private AbstractProduct_B Product2
		{
			get;
			set;
		}

		public virtual AbstractFactory AbstractFactory
		{
			get;
			set;
		}


		public Client(AbstractFactory Factory)
		{
            AbstractFactory = Factory;
            Product1 = Factory.CreateProductA();
            Product2 = Factory.CreateProductB();
		}

	}
}

