using System;
using cuber;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game_nham.Scripts
{
    public class GroundSpawn : MonoBehaviour
    {
        public GameObject groundPrefab;
        public int deltaX;
        
        private int idx = 0;

        public void Start()
        {
            //groundPrefab.GetComponent<SpriteRenderer>().color = GameItemManager.Instance.negative;
            GenerateGround();
            GenerateGround();
            GenerateGround();
            GenerateGround();
            GenerateGround();
            GenerateGround();
        }

        public void GenerateGround()
        {
            var go = Instantiate(groundPrefab, transform);
            go.gameObject.SetActive(true);
            var tempPos = Vector3.zero;
            var rd = Random.Range(5, 10);
            tempPos.x += deltaX * idx + rd;
            go.transform.localPosition = tempPos;

            var flip = Random.Range(0, 100);
            if (flip % 2 == 0)
                go.transform.localScale = new Vector3(1, -1, 1);
            idx++;
            //groundPrefab = go;
        }

        public void reset()
        {
            idx = 0;
            GenerateGround();
            GenerateGround();
            GenerateGround();
            GenerateGround();
            GenerateGround();
            GenerateGround();
        }




        #region InsertCode

       
        public class pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp()
        {
            
        }
        public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp GetpJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(){
        var clasx = new pJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp();
        return  clasx;
    }

    public string RandomStringpJiRgAZvetZRxzZYxgjQHMUFwTeVoYyOYIOqoaemNYcOmvYjEyXDXntcpdUMVDGFvLsp(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu()
        {
            
        }
        public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu GetCcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(){
        var clasx = new CcUHptTPOCoyzvyXLzkLEPdkLOMmxvu();
        return  clasx;
    }

    public string RandomStringCcUHptTPOCoyzvyXLzkLEPdkLOMmxvu(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl()
        {
            
        }
        public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl GetOSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(){
        var clasx = new OSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl();
        return  clasx;
    }

    public string RandomStringOSgfmMEFCjHIpvlVKIsXbonXrWfQDbWEMeCBiCYcLNPZAHl(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA()
        {
            
        }
        public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA GetRugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(){
        var clasx = new RugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA();
        return  clasx;
    }

    public string RandomStringRugrbsWfeXvDbTmaQDqmoYpmubcQHjyRUezxjtDZaJfdXhTcDurrhVpsFtwA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE()
        {
            
        }
        public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE GetnGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(){
        var clasx = new nGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE();
        return  clasx;
    }

    public string RandomStringnGTVEuUbPEJZIlGzVizyDnKkrzABZuOtKRfUgiQfSNHqQlznkEBWKPezvjdE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt()
        {
            
        }
        public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt GetcScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(){
        var clasx = new cScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt();
        return  clasx;
    }

    public string RandomStringcScqWUwQEbgFKRLOrOvycEgQYRomnEWfBRAHGDXPlydacJvrUQsiJDnXlMSFgKdAFADt(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ()
        {
            
        }
        public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ GetmQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(){
        var clasx = new mQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ();
        return  clasx;
    }

    public string RandomStringmQEMYJcvaPFaBeRVyHHemAayWGBuQIbbJ(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW()
        {
            
        }
        public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW GetINmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(){
        var clasx = new INmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW();
        return  clasx;
    }

    public string RandomStringINmJObuzyITtuqwjIQDnndrKQZtuoDbzoAevbsnXuluHfmSWAcW(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA()
        {
            
        }
        public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA GetxYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(){
        var clasx = new xYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA();
        return  clasx;
    }

    public string RandomStringxYBLNOcsiecjtkaCzWHAFGeOWncWIbjknLCqkJA(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class hWuyUjTivCttqaWSoYccdRLzzHoMDSK
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public hWuyUjTivCttqaWSoYccdRLzzHoMDSK()
        {
            
        }
        public hWuyUjTivCttqaWSoYccdRLzzHoMDSK(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public hWuyUjTivCttqaWSoYccdRLzzHoMDSK(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public hWuyUjTivCttqaWSoYccdRLzzHoMDSK GethWuyUjTivCttqaWSoYccdRLzzHoMDSK(){
        var clasx = new hWuyUjTivCttqaWSoYccdRLzzHoMDSK();
        return  clasx;
    }

    public string RandomStringhWuyUjTivCttqaWSoYccdRLzzHoMDSK(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly()
        {
            
        }
        public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly GetwTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(){
        var clasx = new wTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly();
        return  clasx;
    }

    public string RandomStringwTzJskzpLfTqyjPfIKbYLxOhvBJALubqxmCWNkjRrAkHyvPeYNMWZoly(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class xFFKoVzORkKQUUhHszJVQJYYvzVJhNR
    {
        private int buaquadi;
        private string chusx;
        public float gmac;
        private double mciajx;

        public int getX()
        {
            return buaquadi;
        }
        public string Title { get; }
        public string Publisher { get; }
        public string? Isbn { get; }

        public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR()
        {
            
        }
        public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public xFFKoVzORkKQUUhHszJVQJYYvzVJhNR GetxFFKoVzORkKQUUhHszJVQJYYvzVJhNR(){
        var clasx = new xFFKoVzORkKQUUhHszJVQJYYvzVJhNR();
        return  clasx;
    }

    public string RandomStringxFFKoVzORkKQUUhHszJVQJYYvzVJhNR(int length)
    {
        string chars = string.Empty;
        return chars;
    }
 private void NewCode()
        {
            
        }

        #endregion
    }
}