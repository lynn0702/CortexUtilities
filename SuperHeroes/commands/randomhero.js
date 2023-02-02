const { SlashCommandBuilder } = require('discord.js');
const {    makeCharacter,
    discordFormattedHero,
    getMainCharacterDiscordString,
    getPowersetsDiscordString,
    getMilestonesDiscordString} = require("../jfsuperheroes.js");

module.exports = {
	data: new SlashCommandBuilder()
		.setName('randomhero')
		.setDescription('Creates a random hero fit for use in Cortex Prime!')
        .addBooleanOption(option =>
			option
				.setName('fulltext')
				.setDescription('The reason for banning')),
	async execute(interaction) {
        const fulltext = interaction.options.getBoolean('fulltext');
if(fulltext){
    let character = makeCharacter(true);
    await interaction.reply(getMainCharacterDiscordString(character));
    await interaction.followUp(getPowersetsDiscordString(character));
    await interaction.followUp(getMilestonesDiscordString(character));
}
else  await interaction.reply(discordFormattedHero(true));
	},
};
