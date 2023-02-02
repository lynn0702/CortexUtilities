const { SlashCommandBuilder } = require('discord.js');
const {    makeCharacter,
    getPowersetsDiscordString,
    } = require ('../jfsuperheroes.js');

module.exports = {
	data: new SlashCommandBuilder()
		.setName('powersets')
		.setDescription('Gets powersets for a random hero.'),
	async execute(interaction) {
        let character = makeCharacter(true);
        await interaction.reply(getPowersetsDiscordString(character));
	},
};
