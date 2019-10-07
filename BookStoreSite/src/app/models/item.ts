export class Item {
    kind: string;
    id: string;
    eTag: string;
    selfLink: string;
    volumeInfo: VolumeInfo;
}


export class VolumeInfo {
    title: string;
    subtitle: string;
    description:string;
    authors: string[];
    publisher: string;
    publishedDate: string;
    imageLinks: ImageLinks;
}

export class ImageLinks {
    smallThumbnail:string;
    thumbnail:string;
}