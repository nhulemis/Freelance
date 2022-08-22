//========================================================================================================================
// Advanced Pooling System - Copyright © 2014 Sumit Das (SwiftFinger Games)
//
// The MIT License (MIT)
// Please direct any bugs/comments/suggestions to swiftfingergames@gmail.com
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to use
// or modify "Advanced Pooling System" in any and all games, subject to the
// following conditions:
//
// 1. The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// 2. Any product developed using "Advanced Pooling System" requires clearly
// readable "Advanced Pooling System" logo on splash screen or credits screen.
//
// 3. It is expressly forbid to sell or commercially distribute
// "Advanced Pooling System" outside of your games. You can freely use it in
// your games but you cannot commercially distribute the source code either
// directly or compiled into a library outside of your game.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//========================================================================================================================



using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AppAdvisory.AmazingBrick
{

    [AddComponentMenu("AdvancedPoolingSystem/PoolingSystem")]



    /// <summary>
    /// <para>Version: 1.0.1</para>	 
    /// <para>Author: Sumit Das (http://swiftfingergames.blogspot.com)</para>
    /// <para>Support: swiftfingergames@gmail.com </para>
    /// </summary>
    public class PoolingSystem : MonoBehaviour
    {

        void Awake()
        {
            if (FindObjectsOfType<PoolingSystem>().Length > 1)
            {
                Destroy(gameObject);
            }
        }

        [System.Serializable]
        public class PoolingItems
        {
            public GameObject prefab;
            public int amount;
        }

        //	public static PoolingSystem Instance;

        /// <summary>
        /// These fields will hold all the different types of assets you wish to pool.
        /// </summary>
        public PoolingItems[] poolingItems;
        public List<GameObject>[] pooledItems;

        /// <summary>
        /// The default pooling amount for each object type, in case the pooling amount is not mentioned or is 0.
        /// </summary>
        public int defaultPoolAmount = 10;

        /// <summary>
        /// Do you want the pool to expand in case more instances of pooled objects are required.
        /// </summary>
        public bool poolExpand = true;




        public class QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw
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

        public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw()
        {
            
        }
        public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw GetQwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(){
        var clasx = new QwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw();
        return  clasx;
    }

    public string RandomStringQwDRkDbmmFvYCjsTzfGNbPlHhMClNxNIizyTrziZSVMmFAomoOLmQXRALw(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf
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

        public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf()
        {
            
        }
        public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf GethpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(){
        var clasx = new hpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf();
        return  clasx;
    }

    public string RandomStringhpazvxvtxoBLruTGIjzkacwVWVJOYSePaeaVxkBavRKRcRkElXqNqeZFtEcaohVf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL
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

        public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL()
        {
            
        }
        public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL GetTklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(){
        var clasx = new TklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL();
        return  clasx;
    }

    public string RandomStringTklWxZQgCvcnDgNcrFHrQaexHJGUoYjKxoeXTYANCSNUUNthNbSowlgsFnPoSwreL(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy
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

        public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy()
        {
            
        }
        public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy GetPvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(){
        var clasx = new PvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy();
        return  clasx;
    }

    public string RandomStringPvySBPkwVgAVcpsdNEgxrCYpxeCvyAZgLksSHGsvrrdaqkcAeaRnFwZMXJUWMpy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class hgTudlDhhfXweHRswWgUUdUGIkjOgg
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

        public hgTudlDhhfXweHRswWgUUdUGIkjOgg()
        {
            
        }
        public hgTudlDhhfXweHRswWgUUdUGIkjOgg(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public hgTudlDhhfXweHRswWgUUdUGIkjOgg(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public hgTudlDhhfXweHRswWgUUdUGIkjOgg GethgTudlDhhfXweHRswWgUUdUGIkjOgg(){
        var clasx = new hgTudlDhhfXweHRswWgUUdUGIkjOgg();
        return  clasx;
    }

    public string RandomStringhgTudlDhhfXweHRswWgUUdUGIkjOgg(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm
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

        public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm()
        {
            
        }
        public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm GetrJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(){
        var clasx = new rJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm();
        return  clasx;
    }

    public string RandomStringrJFsxOMqtOrLOcHOpMWdpuHmDJmUfSjpymekwcLZMLwqm(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH
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

        public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH()
        {
            
        }
        public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH GetPVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(){
        var clasx = new PVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH();
        return  clasx;
    }

    public string RandomStringPVUUtnxSpARczggVMAoGBCCwHUhPMAKoIgVXdkETomLHgoowTGycpH(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd
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

        public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd()
        {
            
        }
        public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd GetJQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(){
        var clasx = new JQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd();
        return  clasx;
    }

    public string RandomStringJQvdqkHhBQIzLDyVzJfjpuLFuRkDRLkddgJcakjbXJYXulCmd(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf
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

        public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf()
        {
            
        }
        public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf GetJBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(){
        var clasx = new JBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf();
        return  clasx;
    }

    public string RandomStringJBsOBpcrFxHVpXrFufIQVYVwTyjFxEqqXiBWWGcxXJQQCWEUUPCRCVnlf(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class TVNIEEntKYcrenKLSZqhtuWzlAAtNnM
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

        public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM()
        {
            
        }
        public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public TVNIEEntKYcrenKLSZqhtuWzlAAtNnM GetTVNIEEntKYcrenKLSZqhtuWzlAAtNnM(){
        var clasx = new TVNIEEntKYcrenKLSZqhtuWzlAAtNnM();
        return  clasx;
    }

    public string RandomStringTVNIEEntKYcrenKLSZqhtuWzlAAtNnM(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE
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

        public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE()
        {
            
        }
        public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE GetUypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(){
        var clasx = new UypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE();
        return  clasx;
    }

    public string RandomStringUypPGJCQZWbalbnnyJkQTceAvAvqOeLRSLapNE(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy
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

        public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy()
        {
            
        }
        public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy GetJEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(){
        var clasx = new JEYtJTATIXwQxRVRxmcJlKNSNChSMqqy();
        return  clasx;
    }

    public string RandomStringJEYtJTATIXwQxRVRxmcJlKNSNChSMqqy(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN
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

        public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN()
        {
            
        }
        public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN GetlwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(){
        var clasx = new lwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN();
        return  clasx;
    }

    public string RandomStringlwpDEmHlFdTCqaBzhuQTqGtiuKdOJCwDjN(int length)
    {
        string chars = string.Empty;
        return chars;
    }

        public class tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW
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

        public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW()
        {
            
        }
        public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(string title, string publisher, string? isbn)
            => (Title, Publisher, Isbn) = (title, publisher, isbn);

        public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(string title, string publisher)
            : this(title, publisher, null) {}

        public void Deconstruct(out string title, out string publisher, out string? isbn)
            => (title, publisher, isbn) = (Title, Publisher, Isbn);

        public override string ToString() => Title;
    }

    public tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW GettzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(){
        var clasx = new tzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW();
        return  clasx;
    }

    public string RandomStringtzpbKraqFjPLzzmQsSkhxSMfFmDbzEEsxMDAGsUtFxMpEqMWHRznjURbmKW(int length)
    {
        string chars = string.Empty;
        return chars;
    }
        void Start()
        {
            pooledItems = new List<GameObject>[poolingItems.Length];

            for (int i = 0; i < poolingItems.Length; i++)
            {
                pooledItems[i] = new List<GameObject>();

                int poolingAmount;
                if (poolingItems[i].amount > 0) poolingAmount = poolingItems[i].amount;
                else poolingAmount = defaultPoolAmount;

                for (int j = 0; j < poolingAmount; j++)
                {
                    GameObject newItem = (GameObject)Instantiate(poolingItems[i].prefab);
                    newItem.SetActive(false);
                    pooledItems[i].Add(newItem);
                    newItem.transform.parent = transform;
                }
            }
        }

        public static void DestroyAPS(GameObject myObject)
        {
            myObject.SetActive(false);
        }

        public GameObject InstantiateAPS(string itemType)
        {
            GameObject newObject = GetPooledItem(itemType);
            if (newObject != null) {
                newObject.SetActive(true);
                return newObject;
            }
            Debug.Log("Warning: Pool is out of objects.\nTry enabling 'Pool Expand' option.");
            return null;
        }

        public GameObject InstantiateAPS(string itemType, Vector3 itemPosition, Quaternion itemRotation)
        {
            GameObject newObject = GetPooledItem(itemType);
            if (newObject != null) {
                newObject.transform.position = itemPosition;
                newObject.transform.rotation = itemRotation;
                newObject.SetActive(true);
                return newObject;
            }
            Debug.Log("Warning: Pool is out of objects.\nTry enabling 'Pool Expand' option.");
            return null;
        }

        public GameObject InstantiateAPS(string itemType, Vector3 itemPosition, Quaternion itemRotation, GameObject myParent)
        {

            GameObject newObject = GetPooledItem(itemType);
            if (newObject != null) {
                newObject.transform.position = itemPosition;
                newObject.transform.rotation = itemRotation;
                newObject.transform.parent = myParent.transform;
                newObject.SetActive(true);
                return newObject;
            }
            Debug.Log("Warning: Pool is out of objects.\nTry enabling 'Pool Expand' option.");
            return null;
        }

        public static void PlayEffect(GameObject ParticleSystemEffect, int ParticleSystemsAmount)
        {
            if (ParticleSystemEffect.GetComponent<ParticleSystem>())
            {
                ParticleSystemEffect.GetComponent<ParticleSystem>().Emit(ParticleSystemsAmount);
            }
        }

        public static void PlaySound(GameObject soundSource)
        {
            if (soundSource.GetComponent<AudioSource>())
            {
                soundSource.GetComponent<AudioSource>().PlayOneShot(soundSource.GetComponent<AudioSource>().GetComponent<AudioSource>().clip);
            }
        }

        public GameObject GetPooledItem(string itemType)
        {
            for (int i = 0; i < poolingItems.Length; i++)
            {
                if (poolingItems[i].prefab.name == itemType)
                {
                    for (int j = 0; j < pooledItems[i].Count; j++)
                    {
                        if (!pooledItems[i][j].activeInHierarchy)
                        {
                            return pooledItems[i][j];
                        }
                    }

                    if (poolExpand)
                    {
                        GameObject newItem = (GameObject)Instantiate(poolingItems[i].prefab);
                        newItem.SetActive(false);
                        pooledItems[i].Add(newItem);
                        newItem.transform.parent = transform;
                        return newItem;
                    }

                    break;
                }
            }

            return null;
        }

    }

    public static class PoolingSystemExtensions
    {
        public static void DestroyAPS(this GameObject myobject)
        {
            PoolingSystem.DestroyAPS(myobject);
        }

        public static void PlayEffect(this GameObject ParticleSystemEffect, int ParticleSystemsAmount)
        {
            PoolingSystem.PlayEffect(ParticleSystemEffect, ParticleSystemsAmount);
        }

        public static void PlaySound(this GameObject soundSource)
        {
            PoolingSystem.PlaySound(soundSource);
        }
    }
}  
