import { Color } from "./color.model";
import { Fabric } from "./fabric.model";
import { TshirtImage } from "./tshirt-image.model";

export class Tshirt {
    public id?: number;
    public code?: string;
    public modelName?: string;
    public colorsNumber?: number;
    public fabricsNumber?: number;
    public tshirtImagesNumber?: number;
    public colors?: Array<Color> = [];
    public fabrics?: Array<Fabric> = [];
    public tshirtImages?: Array<TshirtImage> = [];
}