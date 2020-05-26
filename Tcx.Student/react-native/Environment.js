const ENV = {
  dev: {
    apiUrl: 'http://localhost:44396',
    oAuthConfig: {
      issuer: 'http://localhost:44396',
      clientId: 'Student_App',
      clientSecret: '1q2w3e*',
      scope: 'Student',
    },
    localization: {
      defaultResourceName: 'Student',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44396',
    oAuthConfig: {
      issuer: 'http://localhost:44396',
      clientId: 'Student_App',
      clientSecret: '1q2w3e*',
      scope: 'Student',
    },
    localization: {
      defaultResourceName: 'Student',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
