import 'package:ecommerce_mobile/model/discount.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';

class DiscountProvider extends BaseProvider<Discount> {
  DiscountProvider() : super("productDiscountBrojIndeksa");

  @override
  Discount fromJson(dynamic json) {
    return Discount.fromJson(json);
  }
}
