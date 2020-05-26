const ENV = {
  dev: {
    apiUrl: 'http://localhost:44335',
    oAuthConfig: {
      issuer: 'http://localhost:44335',
      clientId: 'StartOfTemplate_App',
      clientSecret: '1q2w3e*',
      scope: 'StartOfTemplate',
    },
    localization: {
      defaultResourceName: 'StartOfTemplate',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44335',
    oAuthConfig: {
      issuer: 'http://localhost:44335',
      clientId: 'StartOfTemplate_App',
      clientSecret: '1q2w3e*',
      scope: 'StartOfTemplate',
    },
    localization: {
      defaultResourceName: 'StartOfTemplate',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
