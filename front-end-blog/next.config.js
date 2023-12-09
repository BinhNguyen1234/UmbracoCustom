/** @type {import('next').NextConfig} */
const wwebpack = require("webpack");
const nextConfig = {
    reactStrictMode: false,
    webpack: (config, options) => {
        config.plugins.push(new wwebpack.ProvidePlugin({
            _: "lodash"
        }))

        return config;
    },
};

module.exports = nextConfig;
