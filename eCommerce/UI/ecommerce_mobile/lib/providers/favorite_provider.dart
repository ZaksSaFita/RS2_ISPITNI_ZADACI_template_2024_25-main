import 'package:ecommerce_mobile/model/user_favorite.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';

class FavoriteProvider extends BaseProvider<UserFavorite> {
  FavoriteProvider() : super("favoriteBrojIndeksa");

  @override
  UserFavorite fromJson(dynamic json) {
    return UserFavorite.fromJson(json);
  }
}
