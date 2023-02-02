const { SlashCommandBuilder } = require('discord.js');
const {    makeCharacter,
    getMilestonesDiscordString,
    } = require('../jfsuperheroes.js');

module.exports = {
	data: new SlashCommandBuilder()
		.setName('milestones')
		.setDescription('Gets powersets for a random hero.'),
	async execute(interaction) {
        let character = makeCharacter(true);
        await interaction.reply(getMilestonesDiscordString(character));
	},
};
