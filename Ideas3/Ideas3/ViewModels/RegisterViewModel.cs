﻿using Ideas3.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ideas3.ViewModels
{
    public class RegisterViewModel
    {
        ApiServices _apiServices = new ApiServices();
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async() =>
                {
                    var isSuccess = await _apiServices.RegisterAsync(Email, Password, ConfirmPassword);

                    if (isSuccess)
                        Message = "Registered successfully";
                    else
                        Message = "Retry Later";
                });
            }
        }
    }
}
