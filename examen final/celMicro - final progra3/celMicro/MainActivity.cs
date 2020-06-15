﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace celMicro
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Button BIngreso = FindViewById<Button>(Resource.Id.bingresar);
            Button BSalida = FindViewById<Button>(Resource.Id.bsalir);
            
            Button BHistorial = FindViewById<Button>(Resource.Id.bhistorial);
            BIngreso.Click += (sender, e) => {
                var insertar = new Intent(this, typeof(ActividadInsertar));
                insertar.PutExtra("Datos", "Datos Enviados");
                StartActivity(insertar);

            };
            BSalida.Click += (sender, e) =>
            {
                var Salida = new Intent(this, typeof(ActividadSalida));
                Salida.PutExtra("Datos", "Datos Enviados");
                StartActivity(Salida);
            };
            BMostrar.Click += (sender, e) =>
            {
                var Mostrar = new Intent(this, typeof(ActividadMostrar));

                StartActivity(Mostrar);
            };
            BHistorial.Click += (sender, e) =>
            {
                var Historial = new Intent(this, typeof(ActividadHistorial));

                StartActivity(Historial);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}