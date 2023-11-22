export const RoutingNavBarConstant : Array<ConfigForItem> = [
        {
            textDisplay: "Blog",
            routingHref: "/blog"
        },
        {
            textDisplay: "Projects",
            routingHref: "/projects"
        },
        {
            textDisplay: "About",
            routingHref: "/about"
        },
        {
            textDisplay: "Newsletter",
            routingHref: "/newsletter"
        },
    ]
export interface ConfigForItem {
    routingHref:string,
    textDisplay: string
}
