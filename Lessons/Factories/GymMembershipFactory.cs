﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons.Domain.Factories
{
    internal class GymMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }
        public override IMembership GetMembership()
        {
            GymMembership membership = new(_price)
            {
                Description = _description,
            };

            return membership;
        }
    }
}
