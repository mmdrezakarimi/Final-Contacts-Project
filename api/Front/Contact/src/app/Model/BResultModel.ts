export interface BResultModel<T> {
    success: Boolean;
    data: T;
    errorCode: Number;
    errorMessage: string;
}