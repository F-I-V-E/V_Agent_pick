using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;

namespace V_Agent_pick
{
    internal class AgentList : IEnumerable<Agent>
    {
        public List<Agent> Agents;

        public Agent this[int index]
        {
            get => Agents[index];
            set => Agents[index] = value; 
        }

        public AgentList()
        {
            initialize();
        }
        private void initialize()
        {
            Agents = new List<Agent>();
            Sentinels();
            Initiators();
            Duelists();
            Controller();
        }
        public int getLength()
        {
            return Agents.Count;
        }
        private void Duelists()
        {
            Agents.Add(new Agent("Iso",
                "Duelist",
                "Chinese fixer for hire, Iso falls into a flow state to dismantle the opposition. Reconfiguring ambient energy into bulletproof protection, he advances with focus towards his next duel to the death.",
                new Ability("Contingency",
                    "Equip to assemble prismatic energy. Fire to push an indestructible wall of energy forward that blocks bullets.",
                    1,
                    200,
                    0),
                new Ability("Double Tap",
                    "INSTANTLY start channeling your focus. Once focused: gain a shield which absorbs one instance of damage from any source, and enter a flow state during which downed enemies you kill or damage spawn an energy orb. Shooting this orb refreshes your flow state and your existing shield, or grants another.",
                    1,
                    0,
                    1),
                new Ability("Undercut",
                    "Equip a molecular bolt. Fire to throw it forward, briefly applying Vulnerable to all players it touches. The bolt can pass through solid objects, including walls.",
                    2,
                    200,
                    0)));

            Agents.Add(new Agent("Neon",
                "Duelist",
                "Neon zips around the battlefield with electric speed, outmaneuvering enemies and closing in on them rapidly.",
                new Ability("Relay Bolt",
                    "Throw an energy bolt that bounces and stuns enemies in its area.",
                    1,
                    200,
                    0),
                new Ability("Fast Lane",
                    "Create two walls of energy that block vision and damage enemies passing through.",
                    1,
                    0,
                    1),
                new Ability("High Gear",
                    "Activate to sprint and increase movement speed.",
                    1,
                    300,
                    1)));

            Agents.Add(new Agent("Raze",
                "Duelist",
                "Raze is an explosives expert who demolishes enemies with her heavy-duty grenades and boom bots.",
                new Ability("Paint Shells",
                    "Throw a cluster grenade that deals heavy damage.",
                    1,
                    200,
                    0),
                new Ability("Boom Bot",
                    "Deploy a bot that hunts down enemies and explodes on contact.",
                    1,
                    300,
                    1),
                new Ability("Blast Pack",
                    "Throw an explosive charge that can be detonated manually.",
                    2,
                    200,
                    0)));

            Agents.Add(new Agent("Jett",
                "Duelist",
                "Jett’s agility and speed make her a formidable opponent, always staying one step ahead of her enemies.",
                new Ability("Updraft",
                    "Propel Jett high into the air.",
                    2,
                    150,
                    0),
                new Ability("Tailwind",
                    "Dash a short distance in the direction you're moving.",
                    1,
                    0,
                    1),
                new Ability("Cloudburst",
                    "Throw a cloud that blocks vision.",
                    3,
                    200,
                    0)));

            Agents.Add(new Agent("Phoenix",
                "Duelist",
                "Phoenix’s star power ignites the battlefield with a flash, healing himself and damaging enemies with his fiery abilities.",
                new Ability("Curveball",
                    "Throw a flare that blinds enemies as it curves around corners.",
                    2,
                    250,
                    0),
                new Ability("Hot Hands",
                    "Throw a fireball that heals Phoenix and damages enemies.",
                    1,
                    0,
                    1),
                new Ability("Blaze",
                    "Create a wall of fire that blocks vision and damages enemies passing through.",
                    1,
                    200,
                    1)));

            Agents.Add(new Agent("Reyna",
                "Duelist",
                "Reyna thrives on single combat, consuming the souls of her enemies to heal or become invulnerable.",
                new Ability("Leer",
                    "Cast an eye that nearsights enemies looking at it.",
                    2,
                    250,
                    0),
                new Ability("Devour",
                    "Consume a soul orb dropped by a killed enemy to heal.",
                    4,
                    200,
                    0),
                new Ability("Dismiss",
                    "Consume a soul orb to become invulnerable for a short time.",
                    4,
                    200,
                    0)));

            Agents.Add(new Agent("Yoru",
                "Duelist",
                "Yoru uses deception and misdirection to outplay his enemies and create chaos on the battlefield.",
                new Ability("Fakeout",
                    "Deploy a decoy that mimics footsteps to confuse enemies.",
                    2,
                    100,
                    0),
                new Ability("Blindside",
                    "Throw a flash grenade that bounces off walls before exploding.",
                    2,
                    250,
                    0),
                new Ability("Gatecrash",
                    "Send out a teleport beacon. Reactivate to teleport to its location.",
                    1,
                    200,
                    1)));

        }
        private void Controller()
        {
            Agents.Add(new Agent("Harbor",
             "Controller",
             "Harbor controls the battlefield with powerful water-based abilities that block vision and disrupt enemy positions.",
             new Ability("Cove",
                 "Throw a water sphere that blocks bullets and vision.",
                 1,
                 350,
                 1),
             new Ability("High Tide",
                 "Send out a wall of water that blocks vision and slows enemies.",
                 1,
                 0,
                 1),
             new Ability("Cascade",
                 "Send out a wave that can be stopped mid-way to block vision and slow enemies.",
                 1,
                 150,
                 1)));

            Agents.Add(new Agent("Astra",
                "Controller",
                "Astra uses cosmic powers to manipulate the battlefield, deploying stars that can disrupt and trap her enemies.",
                new Ability("Nova Pulse",
                    "Activate a star to concuss all enemies in its radius.",
                    1,
                    150,
                    1),
                new Ability("Gravity Well",
                    "Activate a star to pull enemies towards its center and weaken them.",
                    1,
                    150,
                    1),
                new Ability("Nebula",
                    "Activate a star to create a smoke cloud that blocks vision.",
                    2,
                    200,
                    0)));

            Agents.Add(new Agent("Brimstone",
                "Controller",
                "Brimstone provides his team with utility and powerful smoke screens that obscure the battlefield.",
                new Ability("Incendiary",
                    "Launch an incendiary grenade that creates a damaging field of fire.",
                    1,
                    250,
                    0),
                new Ability("Stim Beacon",
                    "Deploy a beacon that grants RapidFire to players in its range.",
                    2,
                    100,
                    0),
                new Ability("Sky Smoke",
                    "Use your map to call in smoke screens that block vision.",
                    3,
                    100,
                    1)));

            Agents.Add(new Agent("Omen",
                "Controller",
                "Omen uses shadows and teleportation to confuse and outmaneuver his enemies.",
                new Ability("Shrouded Step",
                    "Teleport a short distance to a targeted location.",
                    2,
                    100,
                    0),
                new Ability("Paranoia",
                    "Send out a shadow that nearsights and deafens enemies.",
                    1,
                    250,
                    1),
                new Ability("Dark Cover",
                    "Throw a shadow orb that expands into a sphere, blocking vision.",
                    2,
                    150,
                    0)));

            Agents.Add(new Agent("Viper",
                "Controller",
                "Viper uses poisonous gas to control the battlefield, manipulating enemy movements and blocking vision.",
                new Ability("Snake Bite",
                    "Launch a projectile that creates a pool of acid, damaging enemies.",
                    2,
                    200,
                    0),
                new Ability("Poison Cloud",
                    "Throw a gas emitter that creates a toxic cloud when activated.",
                    1,
                    200,
                    1),
                new Ability("Toxic Screen",
                    "Deploy a long line of gas emitters that can be activated to create a wall of toxic gas.",
                    1,
                    0,
                    1)));

            Agents.Add(new Agent("Clove",
                "Controller",
                "Scottish troublemaker Clove makes mischief for enemies in both the heat of combat and the cold of death. The young immortal keeps foes guessing, even from beyond the grave, their return to the living only ever a moment away.",
                new Ability("Meddle",
                    "Equip a fragment of immortality essence. Fire to throw the fragment, which erupts after a short delay and temporarily decays all targets caught inside.",
                    1,
                    250,
                    0),
                new Ability("Ruse",
                    "Equip to view the battlefield. Fire to set the locations where Clove’s clouds will settle. Alt Fire to confirm, launching clouds that block vision in the chosen areas. Clove can use this ability after death.",
                    1,
                    150,
                    2),
                new Ability("Pick-Me-Up",
                    "Instantly absorb the life force of a fallen enemy that Clove damaged or killed, gaining haste and temporary health.",
                    1,
                    200,
                    0)));
        }
        private void Sentinels()
        {
            Agents.Add(new Agent("Cypher",
                "Sentinel",
                "The Moroccan information broker, Cypher is a one-man surveillance network who keeps tabs on the enemy's every move. No secret is safe. No maneuver goes unseen. Cypher is always watching.",
                new Ability("Cyber Cage",
                    "Instantly toss the cyber cage. Activate to create a zone that blocks vision and slows enemies.",
                    2,
                    100,
                    0),
                new Ability("Spycam",
                    "Equip a spycam. Fire to place the spycam. Re-use to control the camera and fire a marking dart.",
                    1,
                    0,
                    1),
                new Ability("Trapwire",
                    "Equip a trapwire. Fire to place a tripwire. Enemies crossing will be revealed and dazed unless destroyed.",
                    2,
                    200,
                    0)));

            Agents.Add(new Agent("Deadlock",
                "Sentinel",
                "Deadlock uses advanced technology to control the battlefield and lock down enemy movements.",
                new Ability("GravNet",
                    "Toss a grav-net grenade. Enemies hit are slowed and forced to crouch.",
                    1,
                    200,
                    0),
                new Ability("Barrier Mesh",
                    "Deploy a barrier that blocks projectiles and slows enemies.",
                    1,
                    0,
                    1),
                new Ability("Sonic Sensor",
                    "Deploy a sensor that detects sound and concusses enemies making noise.",
                    2,
                    300,
                    0)));

            Agents.Add(new Agent("Killjoy",
                "Sentinel",
                "The genius from Germany, Killjoy secures areas with deadly gadgets that trap and eliminate her foes.",
                new Ability("Nanoswarm",
                    "Throw a grenade. Activate it to release a swarm of damaging nanobots.",
                    2,
                    200,
                    0),
                new Ability("Turret",
                    "Deploy a turret that fires at enemies in a 180-degree cone.",
                    1,
                    0,
                    1),
                new Ability("Alarmbot",
                    "Deploy a covert bot that hunts down enemies and explodes, applying a debuff.",
                    2,
                    200,
                    0)));

            Agents.Add(new Agent("Sage",
                "Sentinel",
                "Sage creates safety for herself and her team wherever she goes. She can heal allies and resurrect the fallen.",
                new Ability("Slow Orb",
                    "Cast a radianite orb that slows enemies in a large area.",
                    2,
                    200,
                    0),
                new Ability("Barrier Orb",
                    "Create a large, solid wall that blocks movement.",
                    1,
                    400,
                    1),
                new Ability("Healing Orb",
                    "Heal an ally or yourself to full health over time.",
                    1,
                    0,
                    1)));

            Agents.Add(new Agent("Chamber",
                "Sentinel",
                "Chamber, the French weapons designer, brings deadly precision and a range of custom weapons to any fight.",
                new Ability("Trademark",
                    "Place a trap that scans for enemies. When triggered, it destabilizes the terrain around it.",
                    2,
                    150,
                    0),
                new Ability("Rendezvous",
                    "Place two teleport anchors. Re-use to teleport between them.",
                    1,
                    0,
                    1),
                new Ability("Headhunter",
                    "Activate to equip a heavy pistol. Aim down sights for precision.",
                    8,
                    150,
                    0)));

            Agents.Add(new Agent("Vyse",
                "Sentinel",
                "Metallic mastermind Vyse unleashes liquid metal to isolate, trap, and disarm her enemies. Through cunning and manipulation, she forces all who oppose her to fear the battlefield itself.",
                new Ability("Razorvine",
                    "Equip a nest of liquid metal. Fire to launch. Upon landing, the nest becomes invisible. When activated, it sprawls out into a large razorvine nest which slows and damages all players who move through it.",
                    2,
                    150,
                    0),
                new Ability("Arc Rose",
                    "Equip an Arc Rose. Target a surface and fire to place a stealthed Arc Rose, or alt fire to place the Arc Rose through it. reuse to blind all players looking at it. This ability can be picked up to be redeployed.",
                    1,
                    0,
                    1),
                new Ability("Shear",
                    "Equip filaments of liquid metal. Fire to place a hidden wall trap. When an enemy crosses, an indestructible wall bursts from the ground behind them. The wall lasts for a brief time before dissipating.",
                    1,
                    200,
                    0)));

        }
        private void Initiators()
        {
            Agents.Add(new Agent("Fade",
             "Initiator",
             "Fade hunts down enemies using her nightmarish abilities to expose their fears and leave them vulnerable.",
             new Ability("Seize",
                 "Throw an orb that explodes and traps enemies.",
                 1,
                 200,
                 0),
             new Ability("Haunt",
                 "Throw an orb that reveals enemies in its line of sight.",
                 1,
                 0,
                 1),
             new Ability("Prowler",
                 "Send a creature that hunts down and nearsighted enemies.",
                 2,
                 250,
                 0)));

            Agents.Add(new Agent("KAYO",
                "Initiator",
                "KAY/O is a machine of war built for one purpose: neutralizing radiants' powers.",
                new Ability("FRAG/ment",
                    "Throw an explosive fragment that sticks to surfaces and explodes multiple times.",
                    1,
                    200,
                    0),
                new Ability("FLASH/drive",
                    "Throw a flash grenade that blinds enemies in its line of sight.",
                    2,
                    250,
                    0),
                new Ability("ZERO/point",
                    "Throw a suppression blade that disables enemy abilities in its range.",
                    1,
                    0,
                    1)));

            Agents.Add(new Agent("Skye",
                "Initiator",
                "Hailing from Australia, Skye uses nature's strength to heal and scout for her team.",
                new Ability("Regrowth",
                    "Heal all allies in a range over time, cannot heal herself.",
                    1,
                    200,
                    1),
                new Ability("Trailblazer",
                    "Send out a predator that you can control to scout and concuss enemies.",
                    1,
                    250,
                    1),
                new Ability("Guiding Light",
                    "Send out a hawk that flashes enemies on activation.",
                    2,
                    150,
                    0)));

            Agents.Add(new Agent("Sova",
                "Initiator",
                "Sova is a Russian tracker who excels at finding and eliminating enemies from long range.",
                new Ability("Shock Bolt",
                    "Fire an arrow that explodes and deals damage to enemies in its radius.",
                    2,
                    150,
                    0),
                new Ability("Recon Bolt",
                    "Fire a sonar arrow that reveals enemies in its line of sight.",
                    1,
                    0,
                    1),
                new Ability("Owl Drone",
                    "Deploy a pilotable drone that can fire a tracking dart.",
                    1,
                    400,
                    1)));

            Agents.Add(new Agent("Breach",
                "Initiator",
                "Breach uses seismic blasts to disrupt the battlefield, clearing the way for his team.",
                new Ability("Aftershock",
                    "Fire a blast that explodes through walls, dealing heavy damage.",
                    1,
                    200,
                    0),
                new Ability("Flashpoint",
                    "Fire a flashbang through a wall, blinding all enemies on the other side.",
                    2,
                    250,
                    0),
                new Ability("Fault Line",
                    "Equip a seismic blast. Charge it to increase the range and concuss enemies.",
                    1,
                    0,
                    1)));

            Agents.Add(new Agent("Gekko",
                "Initiator",
                "Gekko uses his creatures to scout, damage, and confuse enemies, creating opportunities for his team.",
                new Ability("Mosh Pit",
                    "Throw a grenade that covers a wide area and deals damage over time.",
                    1,
                    200,
                    0),
                new Ability("Dizzy",
                    "Deploy a flying creature that blinds enemies when it spots them.",
                    1,
                    0,
                    1),
                new Ability("Wingman",
                    "Send out a creature that can plant or defuse the spike for you.",
                    1,
                    300,
                    1)));
        }
        public void setCheckBox(CheckBox cb, string Agentname)
        {
            foreach (Agent agent in Agents)
            {
                if (agent.Name == Agentname)
                {
                    agent.ConfigureCheckbox(cb);
                }
            }
        }

        public IEnumerator<Agent> GetEnumerator()
        {
            foreach (Agent agent in Agents)
                yield return agent;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
