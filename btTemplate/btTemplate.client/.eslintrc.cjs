/**
 * Module exports representing ESLint configuration.
 * @module ESLintConfig
 */

module.exports = {
  /**
   * Specifies that this configuration is intended for Node.js environment.
   * @type {object}
   */
  root: true,

  /**
   * Specifies the environment as browser and ECMAScript 2020.
   * @type {object}
   */
  env: { browser: true, es2020: true },

  /**
   * Extends ESLint recommended rules, React recommended rules, React JSX runtime plugin, and React Hooks plugin.
   * @type {string[]}
   */
  extends: [
    'eslint:recommended',
    'plugin:react/recommended',
    'plugin:react/jsx-runtime',
    'plugin:react-hooks/recommended',
  ],

  /**
   * Specifies the files or directories to ignore during linting.
   * @type {string[]}
   */
  ignorePatterns: ['dist', '.eslintrc.cjs'],

  /**
   * Specifies the parser options for ECMAScript version and module source type.
   * @type {object}
   */
  parserOptions: { ecmaVersion: 'latest', sourceType: 'module' },

  /**
   * Specifies settings for React, specifically the version.
   * @type {object}
   */
  settings: { react: { version: '18.2' } },

  /**
   * Specifies plugins to be used, including the React Refresh plugin.
   * @type {string[]}
   */
  plugins: ['react-refresh'],

  /**
   * Specifies ESLint rules to be applied, including custom ones.
   * @type {object}
   */
  rules: {
    /**
     * Disables the rule that prohibits the use of target='_blank' attribute in JSX.
     * @type {string}
     */
    'react/jsx-no-target-blank': 'off',

    /**
     * Specifies custom rule for React Refresh, allowing only exporting components with constant exports.
     * @type {string[]}
     */
    'react-refresh/only-export-components': [
      'warn',
      { allowConstantExport: true },
    ],
  },
};
