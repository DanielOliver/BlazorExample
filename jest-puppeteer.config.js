module.exports = {
    launch: {
      dumpio: true,
      headless: process.env.HEADLESS !== 'false',
    },
    server: {
      command: 'dotnet run --project Blazor.Client',
      port: 5000,
    },
    browserContext: 'default',
  }