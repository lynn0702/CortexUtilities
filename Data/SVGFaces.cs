using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SVGFaces
    {
        public string[] Faces = new[]
        {

            "alien-stare.svg", "bandit.svg", "barbarian.svg", "barbute.svg", "beard.svg", "bird-mask.svg",
            "blindfold.svg", "brain-freeze.svg", "brain-stem.svg", "brain.svg", "caesar.svg", "cleopatra.svg",
            "clown.svg", "coma.svg", "confrontation.svg", "cowled.svg", "cultist.svg", "dead-head.svg", "delighted.svg",
            "diamonds-smile.svg", "doctor-face.svg", "dwarf-face.svg", "egyptian-profile.svg", "elf-ear.svg",
            "eyepatch.svg", "female-vampire.svg", "fish-monster.svg", "fox-head.svg", "frontal-lobe.svg", "gaze.svg",
            "gibbet.svg", "gluttony.svg", "goblin-head.svg", "golem-head.svg", "hood.svg", "horned-reptile.svg",
            "human-ear.svg", "idea.svg", "invisible-face.svg", "iron-mask.svg", "kenku-head.svg", "liar.svg",
            "lizardman.svg", "mad-scientist.svg", "mecha-head.svg", "mecha-mask.svg", "medusa-head.svg",
            "metal-golem-head.svg", "monk-face.svg", "mummy-head.svg", "mustache.svg", "mute.svg", "nailed-head.svg",
            "nefertiti.svg", "ninja-head.svg", "ninja-mask.svg", "nose-front.svg", "nose-side.svg", "nun-face.svg",
            "nurse-female.svg", "nurse-male.svg", "ogre.svg", "one-eyed.svg", "orc-head.svg", "overlord-helm.svg",
            "pig-face.svg", "pirate-captain.svg", "plane-pilot.svg", "police-officer-head.svg", "psychic-waves.svg",
            "pummeled.svg", "pumpkin-lantern.svg", "pumpkin-mask.svg", "pyromaniac.svg", "quick-man.svg",
            "robber-mask.svg", "robot-antennas.svg", "robot-helmet.svg", "sherlock-holmes.svg", "silenced.svg",
            "sleepy.svg", "sly.svg", "snake-bite.svg", "spectacle-lenses.svg", "spectacles.svg",
            "spiked-halo.svg", "spy.svg", "star-struck.svg", "sunglasses.svg", "swallow.svg", "tear-tracks.svg",
            "top-hat.svg", "totem-head.svg", "triton-head.svg", "vampire-dracula.svg", "viking-head.svg",
            "warlock-hood.svg", "witch-face.svg", "wizard-face.svg", "wolf-head.svg", "woman-elf-face.svg"
        };

        public string GetRandomFace()
        {
            return Faces[new Random().Next(0, Faces.Length)];
        }
    }
}
