const { SlashCommandBuilder } = require('discord.js');
const {    makeCharacter,
    getMainCharacterDiscordString }  = require("../jfsuperheroes.js");

module.exports = {
	data: new SlashCommandBuilder()
		.setName('maincharacter')
		.setDescription('Gets a random set of distinctions, affiliations, and specialties.'),
	async execute(interaction) {
        let character = makeCharacter(true);
        await interaction.reply(getMainCharacterDiscordString(character));
	},
};
