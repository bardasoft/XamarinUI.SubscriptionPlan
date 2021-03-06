﻿using SubscriptionPlan.XamarinUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SubscriptionPlan.XamarinUI
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            PlanList = new ObservableCollection<SubscriptionPlanModel>
            {
                new SubscriptionPlanModel
                {
                    Title = "Base",
                    Description = "It's a base plan description",
                    Price = 10
                },
                new SubscriptionPlanModel
                {
                    Title = "Medium",
                    Description = "it's a medium plan description",
                    Price = 30
                },
                new SubscriptionPlanModel
                {
                    Title = "Ultimate",
                    Description = "It's a ultimate plan description",
                    Price = 90
                },
            };
        }

        public ObservableCollection<SubscriptionPlanModel> PlanList { get; set; }

        public SubscriptionPlanModel SelectedItem { get; set; }

    }
}
