using UnityEngine;

namespace PetsIO._Scripts.other
{
    public class Names : MonoBehaviour {

        // Use this for initialization
        void Start () {
            string names = "Lorder, Golum,Svego,Scratch,Minior, Scooter,TrailBoom,Bomber,Crot,Polos,CretoGard,Creamor,Scremer,Dread!!,Tormant,Grotar,trender,Porter,Potter,Mikel,Dragos,Crang,Creos,Lopas,Kayle,Toodas,Gababa,Pilion< Lorak,Tommy,Dreamer,Josef,Joque,Kinderos,Solan,Sonar,Talos,Tanos,Ketozzzz,Dodo,Foley,Fooooty,Mikilos,Positron,Torman,Vivi,Jios,Pisko,Gurad,Jonny,Xeros,Zooomer,Zombie,velos,pooner,Spil,queqweqwe,asdas,qwee,Player35165,Player5466,Player9873,Player1264,Player7897,Player4564,Player9863,Player1216,,Player1233,Player4632,Player7536,Player2678,Player1414,Player3326,Player1366,Player8422,Player9613,Player1499,Player4253,Player17655,Player5549,Player5741,Player2896,Player2137,Player9651,BloodyKnight,xAngeLx,vlom,Maels,oskar61,wanderer_from,amaze,Z1KkY,Crysler,heletch,Ч†Ю,shipilov,Chacha,usist,zingo,excurs,capitan_beans,Cashish,LUNTIK,gour,The knyazzz,American_SnIper,NIGHTMARE,007up,Dr.Dizel,RaNDoM,sportik,Su1c1de,Roger,glx506,volandband,pas,Necron,edik_lukoyanov,Synchromesh,SolomA,Dron128,DeatHSoul,DangErXeTER,Psy,Forcas,Morgot,Aspect,Kraken,Bender,Lynch,Big Papa,Mad Dog,Bowser,O’Doyle,Bruise,Psycho,Cannon,Ranger,Clink,Ratchet,Cobra,Reaper,Colt,Rigs,Crank,Ripley,Creep,Roadkill,Daemon,Ronin,Decay,Rubble,Diablo,Sasquatch,Doom,Scar,Dracula,Shiver,Dragon,Skinner,Fender,Skull Crusher,Fester,Slasher,Fisheye,Steelshot,Flack,Surge,Gargoyle,Sythe,Grave,Trip,Gunner,Trooper,Hash,Tweek,Hashtag,Vein,Indominus,Void,Ironclad,Wardon,Killer,Wraith,Knuckles,Zero,Steel,Kevlar,Lightning,Tito,Bullet-Proof,Fire-Bred,Titanium,Hurricane,Ironsides,Iron-Cut,Tempest,Iron Heart,Steel Forge,Pursuit,Steel Foil,Upsurge,Uprising,Overthrow,Breaker,Sabotage,Dissent,Subversion,Rebellion,Insurgent,Loch,Golem,Wendigo,Rex,Hydra,Behemoth,Balrog,Manticore,Gorgon,Basilisk,Minotaur,Leviathan,Cerberus,Mothman,Sylla,Charybdis,Orthros,Baal,Cyclops,Satyr,Azrael,Mariy_Kis,KATUSHA,KinDer:),,:::Eva:::,BoSoranY,AlfabetkA,⎝”ANGEL”⎛,Äђģęŀ™,•ҰøřΔŗęąm•,SÔ_ŽĐAŊIÊ,ЂĄҎЂИ ÑēбēśŋǻƳǻ,Ĉñĕгуř";
            int rnd = Random.Range(0, 5);
            string[] selectedName = names.Split(char.Parse(","));
		
            if (rnd == 0)
            {
                rnd = Random.Range(1131, 98340);
                GetComponent<Controll>().names = "Player"+rnd;
            }
            else
            {
                GetComponent<Controll>().names = selectedName[Random.Range(0, selectedName.Length)];
            }

            //PlayerPrefs.SetString("namebot", selectedName[Random.Range(0, selectedName.Length)]);
		
            Destroy(this);
        }

    }
}
