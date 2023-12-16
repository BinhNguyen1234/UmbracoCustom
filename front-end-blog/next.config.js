/* eslint-disable @typescript-eslint/no-var-requires */
/** @type {import('next').NextConfig} */
const wwebpack = require("webpack");
const nextConfig = {
    reactStrictMode: false,
    webpack: (config, _) => {
        config.plugins.push(new wwebpack.ProvidePlugin({
            _: "lodash"
        }))

        return config;
    },
    logging: {
        fetches: {
            fullUrl: true,
        },
    }
};

module.exports = nextConfig;
