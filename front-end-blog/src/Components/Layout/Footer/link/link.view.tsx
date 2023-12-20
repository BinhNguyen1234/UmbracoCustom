import { ILinkEntity } from "@/Entities/layout/footer/link/link.type";

export default function LinkFooter({ link }: { link: ILinkEntity }){
    const { href, content } = link
    return <a href={href}>{content}</a>
}