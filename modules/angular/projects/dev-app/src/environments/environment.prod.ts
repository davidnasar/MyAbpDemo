import { Config } from '@abp/ng.core';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'QAManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44399',
    clientId: 'QAManagement_ConsoleTestApp',
    dummyClientSecret: '1q2w3e*',
    scope: 'QAManagement',
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44399',
      rootNamespace: 'QAManagement',
    },
    QAManagement: {
      url: 'https://localhost:44350',
      rootNamespace: 'QAManagement',
    },
  },
} as Config.Environment;
