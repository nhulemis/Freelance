using System;
using UnityEngine;

namespace Game_nham.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed = 5f;
        public float jumpForce = 5f;
        public float fallMultiplier = 5f;
        private bool isJumping = false;
        private bool isGrounded = false;
        private Rigidbody2D rb;

        private bool isreseting;

        private int moveInput = 0;

        public Bullet bullet;
        public float shootingTime = 1f;
        private float countTime = 0;
     
        
        public void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void Update()
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

            if ((Input.GetButtonDown("Jump")|| Input.GetMouseButtonDown(0))&& isGrounded)
            {
                moveInput = 1;
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                isJumping = true;
            }

            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }

            if (transform.position.y < -75 && !isreseting)
            {
                isreseting = true;
                moveInput = 0;
                FindObjectOfType<GroundSpawn>().reset();
                transform.position   =  Vector3.up * 2;
            }

            countTime += Time.deltaTime;
            if (countTime >= shootingTime)
            {
                countTime -= shootingTime;
                Instantiate(bullet, transform);
            }
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Ground"))
            {
                isJumping = false;
                isGrounded = true;
            }
        }

        public void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Ground"))
            {
                isGrounded = false;
            }
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