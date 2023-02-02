const { SlashCommandBuilder } = require('discord.js');



module.exports = {
	data: new SlashCommandBuilder()
		.setName('about')
		.setDescription('Links for supporting documents.'),
	async execute(interaction) {
		// interaction.guild is the object representing the Guild in which the command was run
		await interaction.reply(
            "These characters are generated using a procedure designed by Jeremy Forbing."
            +"\nThe process is outlined here: https://docs.google.com/document/d/1CiZwR1cMcBa1pUYRxXFFId9YfPmhqzO-JOQ8uLb4tCE"
            +"\nAll miliestones are available here: https://docs.google.com/document/d/1GRVdMo7x-Q-8n7dFpiDr2Q9kK8YWGCJ8hbXeWSt10HY"
        );
	},
};